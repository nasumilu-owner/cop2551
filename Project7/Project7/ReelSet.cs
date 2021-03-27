using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Project7
{
    /// <summary>
    /// Represents a slot machines set of 3 reels.
    /// </summary>
    public partial class ReelSet : UserControl
    {
       
        /// <summary>
        /// Ligthweight private class of arguments to pass into the reel spin Action delegate
        /// </summary>
        private class SpinTaskData
        {
            public Reel reel;
            public int spins;
            public Label label;
        }

        /// <summary>
        /// Generate a random number to determine a number of spins for the reel.
        /// </summary>
        private readonly Random random = new Random();

        /// <summary>
        /// Constructs the ReelSet
        /// </summary>
        public ReelSet()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Property the gets the ReelSet's Reel objects as a List.
        /// </summary>
        public List<Reel> Reels
        {
            get => new List<Reel> { reel1, reel2, reel3};
        }

        /// <summary>
        /// Action delegate to asynchronously spin the a reel
        /// <see cref="https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/task-based-asynchronous-programming"/>
        /// </summary>
        /// <param name="args"></param>
        private static void SpinReel(Object args)
        {
            var data = args as SpinTaskData;
            data.label.Text = String.Empty;
            data.reel.NumSpins = data.spins;
            data.reel.Spin();
            data.label.Text = data.reel.ToString();
        }

        /// <summary>
        /// Spins the ReelSet
        /// 1. Declare and initalize an array of Task using the Task.Factory.StartNew
        /// 2. Wait until all the Tasks are completed
        /// 3. Determine the SpinResults from the Reels once spinn is complete.
        /// </summary>
        public SpinResult Spin()
        {
            
            // Create my task to spin the reels
            Task[] spinTask = new Task[] {
                Task.Factory.StartNew(SpinReel, new SpinTaskData{reel = reel1, label = reel1Label, spins = this.random.Next(15, 26) }),
                Task.Factory.StartNew(SpinReel, new SpinTaskData { reel = reel2, label = reel2Label, spins = this.random.Next(15, 25) }),
                Task.Factory.StartNew(SpinReel, new SpinTaskData { reel = reel3, label = reel3Label, spins = this.random.Next(15, 26) })
            };
            // Wait until all 3 reels are done spinning.
            Task.WaitAll(spinTask);

            // Linq Groups each reel value and then gets the max value from the results
            // It doesn't matter what fruit is showing just that there are zero, two, or three matches
            // Possible max results are
            //
            // 1 = Lost
            // 2 = 2x
            // 3 = 3x

            int max = this.Reels.GroupBy(
                r => r.Value,
                r => r.Value,
                (key, group) => new { Value = key, Count = group.Count()})
                .Max(o => o.Count);

            if(max == 1)
            {
                return SpinResult.Lost;
            }
            // 2 & 3 the value can static cast
            return (SpinResult)max;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Project6
{
    /// <summary>
    /// Class reads data from two files, one file with the baseball teams and another with 
    /// World Series names. 
    /// 
    /// This project required:
    /// 1. A file of baseball teams is read an used to populate a list box.
    /// 2. When the user selects a baseball team from the list box it will
    ///    display the number of world series that team had one. The world series
    ///    wins are stored in another file.
    ///    
    /// This could also be possible one file of winning team names, populated the list box with 
    /// only distinct baseball teams and then used that list to count the number of world series
    /// wins. The LINQ makes this very easy to do by using <see cref="WorldSeriesService.UniqueTeams"/>
    /// 
    /// </summary>
    class WorldSeriesService
    {
        /// <summary>
        /// Teams Data
        /// </summary>
        private IDataProvider<String> teams;
        /// <summary>
        /// Winners Data
        /// </summary>
        private IDataProvider<String> winners;


        /// <summary>
        /// WorldSericeService default construct uses the following names in the
        /// appliations current path.
        /// 
        /// Teams - Teams.txt
        /// World Series Winners - WorldSeries.txt
        /// </summary>
        public WorldSeriesService() : this("Teams.txt", "WorldSeries.txt") { }

        /// <summary>
        /// Constructs a WorldSeriesService with its data found in the path two arguments.
        /// 
        /// </summary>
        /// <param name="teamFilePath">The file path to the team data</param>
        /// <param name="worldSearisPath">The file path to the world series winner data</param>
        public WorldSeriesService(String teamFilePath, String worldSearisPath) : this(new FileDataProvider(teamFilePath), new FileDataProvider(worldSearisPath)) {}

        /// <summary>
        /// Constructs a WorldSeriseService using the two IDataProvides object to get the teams and winners.
        /// </summary>
        /// <param name="teamsDataProvider"></param>
        /// <param name="winnerDataProvider"></param>
        public WorldSeriesService(IDataProvider<String> teamsDataProvider, IDataProvider<String> winnerDataProvider)
        {
            this.teams = teamsDataProvider;
            this.winners = winnerDataProvider;
        }

        /// <summary>
        /// Gets/Sets the TeamDataProvider used to get the list of teams.
        /// </summary>
        public IDataProvider<String> TeamDataProvider
        {
            get => this.teams;
            set => this.teams = value;
        }

        /// <summary>
        /// Get/Sets the WinnerDataProvider used to get the list of WorldSeries winners.
        /// </summary>
        public IDataProvider<String> WinnersDataProvider
        {
            get => this.winners;
            set => this.winners = value;
        }

        /// <summary>
        /// Get the Teams data
        /// This may throw an exception(s) <see cref="FileDataProvider.Data"/> for
        /// more information.
        /// </summary>
        public List<String> Teams
        {
            get => this.teams.Data;
        }

        /// <summary>
        /// Get the Winners data
        /// This may throw an exception(s) <see cref="FileDataProvider.Data"/> for
        /// more information.
        /// </summary>
        public List<String> Winners
        {
            get => this.winners.Data;
        }

        public IEnumerable<String> UniqueTeams
        {
            get => this.winners.Data.Distinct<String>();
        }

        /// <summary>
        /// Gets the number of world series wins for parameter team.
        /// 
        /// This may throw an exception(s) <see cref="FileDataProvider.Data"/> for
        /// more information.
        /// 
        /// </summary>
        /// <param name="team"></param>
        /// <returns></returns>
        public int NumWins(String team)
        {
            /*
            int count = 0;
            foreach(String str in this.Winners)
            {
                if(str == team)
                {
                    count++;
                }
            }
            return count;
            */
            return this.Winners.FindAll(str => str == team).Count;
        }

    }
}

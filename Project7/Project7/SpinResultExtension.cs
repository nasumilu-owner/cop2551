using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project7
{

    /// <summary>
    /// Possible results from playing the slot machine
    /// </summary>
    public enum SpinResult
    {

        [Display(Name = "Lost")]
        Lost = -1,
        [Display(Name = "Winner 2X")]
        Win2X = 2,
        [Display(Name = "Winner 3X")]
        Win3X = 3
    }

    public static class SpinResultExtension
    {

        /// <summary>
        /// Calculates the winnings of a SpinResult for argument bet
        /// </summary>
        /// <param name="result"></param>
        /// <param name="bet"></param>
        /// <returns></returns>
        public static decimal CalculateWinnings(this SpinResult result, decimal bet)
        {
            return (decimal) result * bet;
        }

        /// <summary>
        /// Gets a diplay name for a SpinResult using the DisplayAttribute annotation.
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static String DisplayName(this SpinResult result)
        {
            // C# reflection is ugly or i'm just used to Java's reflection.
            return result.GetType()?
                .GetField(result.ToString())
                .GetCustomAttribute<DisplayAttribute>()
                .Name;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// the unique identifier for the prize 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the numeric identifier for the place (2 for second place, etc)
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// the friendly name for the place(second place, first runner up)
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// the fixed amount this place earns or zero if it is not used
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// the number that represents the percetage of the overall take or 
        /// zero if it is not used. the percentage is a fraction of 1
        /// (so 0.5 for 50%)
        /// </summary>
        public double PrizePercentage { get; set; }

        /// <summary>
        /// constructor take something in and does nothing for the 
        /// </summary>

        public PrizeModel()
        {

        }
        // create an overloaded contructor to do all parsing - convert if needed and put in 
        // perspective properties 
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue; // all we need is a safe parse and default is zero

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// represents the score for this particular team 
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// represents the matchup that htis team came 
        /// from as teh winner 
        /// </summary>
        public MatchUpModel ParentMatchup { get; set; }


    }

}

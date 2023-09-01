﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class MatchUpModel
    {
        // <summary>
        /// the unique identifier for the person
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents one match in the tournament
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// The winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round this match is a part of. 
        /// </summary>
        public int MatchupRound { get; set; }

    }
}

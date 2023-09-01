using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        /*Creat our match up for the tournament - then create matches for the tournament 
           // TODO - wire out matchups 
           // List list of matchup model - list of matchupEntriesMode, winner and round
           // 1. order our list randomly of teams
           // 2. check list is big enough ! add in byes 2 *2 *2*2  2^4 power
           // 3. create our first round of matchups
           // 4. create every round after dividing by 2 -
           // 8 teams play four matchups - four teams will have two matchups - 2 teams will have a matchup
           // 8 matchups - 4 matchups - 2 matchups - 1 matchup */
        public static void CreateRounds(TournamentModel model)
        { // quarter back method 
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRound(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);

            model.Rounds.Add(CreateFirstRounds(byes, randomizedTeams));
            CreateOtherRounds(model, rounds);

        }
        // create other rounds
        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            // create other rounds
            int round = 2;
            List<MatchUpModel> previousRound = model.Rounds[1];// grab the first round of the matchupmodel ]            while (round <= rounds)
            List<MatchUpModel> currRound = new List<MatchUpModel>();
            MatchUpModel currMatchup = new MatchUpModel();

            while (round <- rounds)

            {
                foreach (MatchUpModel match in previousRound)
                {
                    // added a new matchup entry
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });

                    if(currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchUpModel();
                    }
                }
                model.Rounds.Add(currRound);
                // previous round equals current round 
                previousRound = currRound; // puts into previous round 
                // reset current round
                currRound = new List<MatchUpModel>();
                round += 1;

            }
        }
        // match ups 
        private static List<MatchUpModel> CreateFirstRounds(int byes, List<TeamModel> teams) 
        { 
            List<MatchUpModel> output = new List<MatchUpModel>();
            MatchUpModel curr = new MatchUpModel();

            foreach (TeamModel team in teams) 
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });
                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchUpModel();

                    if (byes > 0) 
                    {
                        byes -= 1;
                    }
                }
            }
            return output;
        }
        // number of byes
        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            // how many teams total in our round
            int totalTeams = 0;

            for (int i = 1; i < rounds; i++)
            {
                totalTeams *= 2;

            }
            output = totalTeams - numberOfTeams;
            return output;
        }
        // 4. create every round after dividing by 2 -
        private static int FindNumberOfRound(int teamCount) 
        {
            int output = 0;
            int val = 2;

            while (val < teamCount) 
            {
                // output = output + 1
                output += 1;

                // val = val * 2
                val *= 2;

            }
            return output;
            
        }
        // order rounds randomly
        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            // Radnomize a List - return an order list - order 
            // order entries by by guid.newguid()
            // cards.OrderBy(a => Guid.NewGuid()).Tolist);
            return teams.OrderBy(x => Guid.NewGuid()).ToList();

        }
    }
}

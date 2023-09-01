using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using System.IO;
using System.Formats.Tar;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) // PrizeModels.csv
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();

        }
        // this is for text connectcion to create the PrizeModel
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            // building the model in the text file 
            // loop through every item in text file 
            List<PrizeModel> output = new List<PrizeModel>();

            // there are no lines but it will create an empty list 
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                // parsing numbers 
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }
        // this is for text connectcion to create the PersonModel
        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            /*// create a list of person model output and create a new one for each string line of line 
            // building the model in the text file 
            // loop through every item in text file */
            List<PersonModel> output = new List<PersonModel>();
            // repeating ourselves using different models and different mapping 
            // create one method that does any different type but it is complex or use automapper 
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');// make sure there are no commas in our data
                // no parsing with strings 
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellPhoneNumber = cols[4];
                output.Add(p);
            }
            return output;
        }
        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            // id , team name, listof ids separated by the pipe 
            // 3, Tims Team, 1,| 3|5 then pull these people out 
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(",");

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];
                // deal with the last column that has ids for people 
                string[] personIds = cols[2].Split("|");
                
                // deal with looking up peoples ids
                foreach (string id in personIds) 
                {
                    /*people.where is taking the list of people in our text file search for it 
                     * and where the id of the person in the list matches the id of the person 
                     * each id is unique and we shall never have more than one 
                     * give us the first item - if there are zero it will break the program- we want it 
                     * to crash our program then add it to the list of object 
                     * then it will add to our team members list 
                     
                     */
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }  
                output.Add(t);

            }
            return output;

        }
        public static List<TournamentModel> ConvertToTournamentModels
            (this List<string> lines , 
            string teamFileName, 
            string peopleFileName,
            string prizeFileName)
        {
            // id = 0 , tournamentName = 1 , entryfee = 2, entered teams = 3 prizes = 4 round = 5
            // id, tournamentName, EntryFee, (id|id|id - Entered Teams), (id|id|id - prizes),
            // (Round - 2 layer array - id^id^id (one list of matchup model)|id^id^id|id^id^id)
            // create a text file or a tournament model for every line 
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
            List<PrizeModel> prizes = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModels();


            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                // create new tournament model
                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                // entered teams split by the pipe 
                string[] teamIds = cols[3].Split('|');

                // get team ids 
                foreach (string id in teamIds)
                {
                    // look up on people load list of teams and find the team based on the id
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }
                // get prizes info 
                string[] prizeIds = cols[4].Split('|');

                foreach(string id in prizeIds)
                {
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }
                // TODO - Capture rounds information 
                output.Add(tm);
            }
            return output;
        }
        public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (TournamentModel tm in models)
            {
                lines.Add($@"
                            {tm.Id},
                            {tm.TournamentName},
                            {tm.EntryFee},
                            { ConvertTeamListToString(tm.EnteredTeams) },
                            { ConvertPrizeListToString(tm.Prizes)},
                            { ConvertRoundListToString(tm.Rounds)}");
            }
            // convert to full file path
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        private static string ConvertRoundListToString(List<List<MatchUpModel>> rounds)
        {
            // (Round - 2 layer array - id^id^id (one list of matchup model)|id^id^id|id^id^id)
            // create a text file or a tournament model for every line 
            // take the list to a string 
            string output = "";

            // what happens if we have zero people in our list 
            if (rounds.Count == 0)
            {
                return "";
            }
            // result example 2|5|
            foreach (List <MatchUpModel> r in rounds)
            {
                output += $"{ ConvertMatchupListToString(r) } |";
            }
            // substring of our output - start at position 0 go to the end
            // and then delete -1 take off trailing pipe ( zero based array) 

            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string ConvertMatchupListToString(List<MatchUpModel> matchups)
        { // take the list to a string 
            string output = "";

            // what happens if we have zero people in our list 
            if (matchups.Count == 0)
            {
                return "";
            }
            // result example 2|5|
            foreach (MatchUpModel m in matchups)
            {
                output += $"{m.Id}^";
            }
            // substring of our output - start at position 0 go to the end
            // and then delete -1 take off trailing pipe ( zero based array) 

            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string ConvertTeamListToString(List<TeamModel> teams) 
        {
            // take the list to a string 
            string output = "";

            // what happens if we have zero people in our list 
            if (teams.Count == 0)
            {
                return "";
            }
            // result example 2|5|
            foreach (TeamModel t in teams)
            {
                output += $"{t.Id} |";
            }
            // substring of our output - start at position 0 go to the end
            // and then delete -1 take off trailing pipe ( zero based array) 

            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            // take the list to a string 
            string output = "";

            // what happens if we have zero people in our list 
            if (prizes.Count == 0)
            {
                return "";
            }
            // result example 2|5|
            foreach (PrizeModel p in prizes)
            {
                output += $"{p.Id} |";
            }
            // substring of our output - start at position 0 go to the end
            // and then delete -1 take off trailing pipe ( zero based array) 

            output = output.Substring(0, output.Length - 1);
            return output;
        }
        // converting to text file for text connections or csv file for PrizeModel
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {

                lines.Add($"{ p.Id}, { p.PlaceNumber}, { p.PlaceName}, { p.PrizeAmount}, { p.PrizePercentage}");
            }
            // convert to full file path
            File.WriteAllLines(fileName.FullFilePath(), lines);

        }
        // Helper to save to peopleFile a list of people or personModel  
        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{ p.Id},{ p.FirstName},{ p.LastName}, {p.EmailAddress},{ p.CellPhoneNumber}");
            }
            
            File.WriteAllLines(fileName.FullFilePath(), lines);// wtite all line to filename in the file path convert to full file path
        }
        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                // deal with the pipe set created convertpeoplelist to string
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);// wtite all line to filename in the file path convert to full file path
        }
        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            // take the list to a string 
            string output = "";

            // what happens if we have zero people in our list 
            if (people.Count ==0) 
            {
                return "";
            }
            // result example 2|5|
            foreach (PersonModel p in people) 
            {
                output += $"{p.Id} |";
            }
            // substring of our output - start at position 0 go to the end
            // and then delete -1 take off trailing pipe ( zero based array) 
           
            output = output.Substring(0, output.Length - 1);
            return output;
        }
    }
}

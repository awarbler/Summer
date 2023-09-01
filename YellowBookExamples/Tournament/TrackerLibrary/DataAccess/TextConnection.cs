using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Drawing.Printing;

namespace TrackerLibrary.DataAccess
{
    public class TextConnection : IDataConnection
    { // add file names 
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";
        // TODO - Wire up createPerson 
        public PersonModel CreatePerson(PersonModel model)
        {/*// load txt file convert text to convert person models / create conver to person model in textconnectorprocessor 
            // created converttopersonmodels to create people
            // take file name convert to fullpath loaded the file to see if it exist otherwise returns empty list
            // takes empty list or a list converst to a list of person model */
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            // find the max id initialize at one so if max id is at one if the list is empty 
            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            people.Add(model); //add the new record to the list with the new id max plus 1 
            people.SaveToPeopleFile(PeopleFile);
            return model;
        }
        //  wire up the createprize for text files
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">the prize information </param>
        /// <returns>the prize information, including the unique identifier </returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // load txt file convert text to prize model 
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // find the max id 
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            // currentId += 1; // this will add more than one record at a time 
            prizes.Add(model); //add the new record to the new id max plus 1

            // convert the prizes to a list string do this in the text helper 

            // save the list string ot text file 
            prizes.SaveToPrizeFile(PrizesFile);

            // we have to return a value of the model that we added the id to 

            return model;

        }
        public TeamModel CreateTeam(TeamModel model)
        {
            // saving only one table 
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
            // get the id
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            teams.Add(model);

            // team
            teams.SaveToTeamFile(TeamFile);
            return model;
            //TODO - refactor all return Model by changing to public voids. 
        }
        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels(TeamFile, PeopleFile, PrizesFile);
            // add new entry
            // get the id
            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            tournaments.Add(model);
            // team
            tournaments.SaveToTournamentFile(TournamentFile);
        }
        // implement the textfile for PesonModels return is harder to test 
        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }
        public List<TeamModel> GetTeam_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
        }
    }
}

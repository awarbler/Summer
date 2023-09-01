using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        // this is a contract methods properties 
        // interface only have public contract terms
        PrizeModel CreatePrize(PrizeModel model);
        // create person for person model
        PersonModel CreatePerson(PersonModel model);
        // create team 
        TeamModel CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);
        // create a new item in contract a list personmodel to get all people 
        // use get to get records back and we want all of the people 
        List<PersonModel> GetPerson_All();
        // read for the team model 
        List<TeamModel> GetTeam_All();

        

    }
}

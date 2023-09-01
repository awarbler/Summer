using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        // gives us all the teams in the database and we will put it in the list of teamModel
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpList();
        }// add a breakpoint for debugging
        private void WireUpList()// hook up drop down to teamModel list 
        {
            seletTeamDropDown.DataSource = null;
            // wiring up team drop down
            seletTeamDropDown.DataSource = availableTeams;
            seletTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamListBox.DataSource = null;
            // wiring up team list Box 
            tournamentTeamListBox.DataSource = selectedTeams;
            tournamentTeamListBox.DisplayMember = "TeamName";

            prizeListBox.DataSource = null;
            // wire up prizes list box
            prizeListBox.DataSource = selectedPrizes;
            prizeListBox.DisplayMember = "PlaceName";
        }
        // wire up add team button to move team to teams list box moves available team selected team to teams/players listBox
        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)seletTeamDropDown.SelectedItem;
            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpList();
            }
        }
        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            /* // call the createPrize form use IprizeRequester and use this 
             * this represent this instance CreateTournament form and implement 
             * the IprizeRequester fullfiller
             */
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show(); // this will show the form
        }

        /* implement the iprizerequester
         * Get back from the form a prizeModel - fill form in and put prize in list - 
             * pass in the instance of the createtournment form to createprizeform  
             * have a public method to save prize 
             * Dont tight couple so have loose coupling 
         */
        public void PrizeComplete(PrizeModel model)
        {
            // take prizeModel and put it into the list of selected prizes
            selectedPrizes.Add(model);
            //wire up the list 
            WireUpList();
        }

        /*
         * wire up team create new link - for select teams this will create a new team 
         * use ITeamRequester to */

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpList();
        }

        // wire up the link click 
        private void createNewLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpList();
            }
        }

        private void removePrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizeListBox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
                //does not available prizeListBox -  not storing - do we delete or remove 
                // we are not going to perform a delete 
                WireUpList();
            }
        }

        // wire up new tournament or create tournament 
        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            /* validate data try to convert value entryFeeValue .text 
             * to type decimal then send it out through fee variable 
             * if i dont send zero out to fee and a false to boolean 
             * if fee is not acceptable show messagebox and a messagebutton to click ok
             * as well as a messageBoxIcon error 
             */
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);
            if (!feeAcceptable)
            {
                MessageBox.Show("Please enter a valid entry fee ", 
                    "Invalid Fee", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;// stops the processing at this point you hae a valid fee
            }
            // create our tournament model 
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameValue.Text;
            tm.EntryFee = fee; // parse this add an error handler
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // TODO - wire out matchups 
            /*Creat our match up for the tournament - then create matches for the tournament 
            // List list of matchup model - list of matchupEntriesMode, winner and round
            // 1. order our list randomly of teams
            // 2. check list is big enough ! add in byes 2 *2 *2*2  2^4 power
            // 3. create our first round of matchups
            // 4. create every round after dividing by 2 -
            // 8 teams play four matchups - four teams will have two matchups - 2 teams will have a matchup
            // 8 matchups - 4 matchups - 2 matchups - 1 matchup */
            TournamentLogic.CreateRounds(tm);



            /* // create a tournament entry is it active or not 
             * create all of the prizes entryies save prizes tournament id and prize id 
             * create all of team entries */
            GlobalConfig.Connection.CreateTournament(tm);
            
        }
    }
}


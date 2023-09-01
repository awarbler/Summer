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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form

    { /*
         * create a private list of person for list box or populate list box
         * wiring up teamMemberListBox 
         * class level create list of person for available and selected team members
         * - not tied to a tournament 
         * limit will not be in drop down 
         * create a method to wire up these two list 
         * one way to make the list but the best cleaner way is to do the following 
         * load list data
         * call global connection
         * get all people put in the availabe team members 
         * or directly in private list to make it cleaner 
        private List<PersonModel> availableTeamMembers = new List<PersonModel>();// 
        */
        //private List<PersonModel> availableTeamMembers = new List<PersonModel>();
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
            //CreateSampleData(); // Testing 
            WireUpLists();
            //LoadListData(); // add it to the availableteamMembers 
        }
        /* this method is to create a sample to confirm that WireUpLists is working 
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Stormy" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jame", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
        }*/
        /*  wire up our dropdown comment box and our list box to our list  
         *  look at our display memeber it is a string one property in our person model 
         *  Add selectTeamMember drop down and name it availableTeamMembers
         *  which property do we want to pull over to represent a person in displayMember
         *  we dont have one so create one in the person model as FullName
         *  then add selectTeamMemberdropdown displaymember with FullName from personModel
         *  Add the team member list box datasource as selectedTeamMembers
         *  displayMember by FullName
         *  How do we show it 
         */
        private void WireUpLists()
        {
            //TODO - BETTER WAY TO REFRESH DATA BINDING
            // forces a refresh - trigger event loops 
            selectTeamMemberDropDown.DataSource = null;

            // select team member dropdown no binding source needed 
            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            // forces a refresh trigger event loops 
            teamMemberListBox.DataSource = null;

            // available listbox 
            teamMemberListBox.DataSource = selectedTeamMembers;
            teamMemberListBox.DisplayMember = "FullName";
        }
        // this method is double work it can be deleted because we already added it. 
        private void LoadListData()
        {
            availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        }
        /* personModel creates a new person for csv
         * but we also want to create a new member to our teamlistBox immediately
         * using again data structures add, delete, amend. 
         */
        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // use person model to get info from form to create a new member to the team 
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellPhoneNumber = cellPhoneValue.Text;

                // now we have to save it to model 
                p = GlobalConfig.Connection.CreatePerson(p);

                // before we wipe out we need to add yo the selected team member list
                selectedTeamMembers.Add(p); // this adds to the member list 
                // this will refresh the list 
                WireUpLists();

                // clear out the form 
                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information, " +
                    "Please fill in all of the fields.");
            }
        }
        /* validate form 
        // TODO add validation to the form 
        // check to value of each line */
        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (cellPhoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        /* Add Member button, select team member from dropdown 
        // add person to team member list 
        // objectd instance 
        // Using data structures 
        // refresh */
        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;//  usig list of personmodel
            // null showed up and we need to put in an exception for null
            if (p != null)
            {
                availableTeamMembers.Remove(p);// removes person from available team members list 
                selectedTeamMembers.Add(p); // this adds to the member list 
                WireUpLists();// this will refresh the list 

                //selectTeamMemberDropDown.Refresh();// debugging test 
                //teamMemberListBox.Refresh();// debugging and test  
            }
        }
        /* remove selected button moves person from team member list to 
* to select team member drop down
* basically the person is no longer on a team and they are available to participate 
* on a team.       
*/
        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMemberListBox.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
                WireUpLists();
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            // send and receive team name each method needs to do one thing
            // creating an entire team 
            // two different inserts one set 
            TeamModel t = new TeamModel();// create team member object 
            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers; // team members 
            GlobalConfig.Connection.CreateTeam(t);// t = to capture t - we can do t = GlobalConfig.Connection.CreateTeam(t)

            callingForm.TeamComplete(t);
            this.Close();
        }
    }
}

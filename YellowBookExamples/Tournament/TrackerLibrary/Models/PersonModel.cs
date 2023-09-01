using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// the unique identifier for the person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The first name of the person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The last name of the person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The primary email address of the person 
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// the primary cell pohne number of the person
        /// </summary>
        public string CellPhoneNumber { get; set; }

        /// <summary>
        /// Create a method that will get the full name 
        /// </summary>
        /*create a property to pull into selected members list and available member list 
         * create a read only method - we could do a propfull function 
         * and delete what we dont want or type it out */
        public string FullName
        {
            get 
            { 
                return $"{ FirstName } { LastName }"; 
            }
            
        }

    }
}

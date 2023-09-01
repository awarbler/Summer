using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public interface IPrizeRequester
    {
        /* whoever implements this model will have one method called prize coplete
         * takes in a prizeModel . use interface and have iprize requester caller 
         * Pass in prizeModelwhoever implements */ 
        void PrizeComplete(PrizeModel model);
    }
}

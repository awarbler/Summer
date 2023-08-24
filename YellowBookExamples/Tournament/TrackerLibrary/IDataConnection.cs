using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        // this is a contract methods properties 
        // interface only have public contract terms
        PrizeModel CreatePrize(PrizeModel model);
        // no code goes into here 


    }
}

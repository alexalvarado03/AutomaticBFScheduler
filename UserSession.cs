using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*******************************
 Code written by: Alex Alvarado
 This code is for Phoenix Book Company LLC.
 Last Edited: 5/27/2025
 ******************************/

namespace BFConfigApp
{
    public enum Infrastructure
    {
        Small,
        Large,
        Custom
    }

    //This class will hold the data objects for building a configuration
    public class UserSession
    {
        public Dictionary<string, int> AllCaseNum { get; set; } = new(); //holds the case type as key and number of those cases as value

        public string Linens { get; set; } = string.Empty; //uses string as number of linens because can have >10 **Will be configured in later logic of app**

        public int MinCashRange { get; set; } //int value to hold Min Cash

        public int MaxCashRange { get; set; } //int value to hold max cash

        public bool IsTableTop { get; set; } //bool to say if the fair is table top fair

        public Infrastructure selectedInfra { get; set; } //enum that holds the infrastructure value
    }
}

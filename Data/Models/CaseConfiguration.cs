using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BFConfigApp.Data.Models;

namespace BFConfigApp.Data.Models
{
    public class CaseConfiguration
    {
        [Key]
        public int ConfigId { get; set; } //Primary key for the configuration

        public List<CaseDetail> CaseDetails { get; set; } = new();

        [NotMapped]
        public Dictionary<string, int> AllCaseNum { get; set; } = new(); //holds the case type as key and number of those cases as value

        public int TotalCaseNum { get; set; }   //Holds the total number of cases for this configuration

        public string Linens { get; set; } = string.Empty; //uses string as number of linens because can have >10 **Will be configured in later logic of app**

        public int MinCashRange { get; set; } //int value to hold Min Cash

        public int MaxCashRange { get; set; } //int value to hold max cash

        public bool IsTableTop { get; set; } //bool to say if the fair is table top fair

        public Infrastructure SelectedInfra { get; set; } //enum that holds the infrastructure value

        public string ConfigurationName { get; set; } = string.Empty; // holds the name of the configuration

        public int UserId { get; set; } //Key that connects to user
    }
}

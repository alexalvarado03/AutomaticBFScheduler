using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BFConfigApp.Data.Models;

namespace BFConfigApp.Data.Models
{
    public class CaseDetail
    {
        public TypeOfCase CaseType { get; set; } // Holds the type of case

        public string CaseName { get; set; } = string.Empty; //Holds the name of case

        [Key]
        public int CaseId { get; set; } //Unique Id and primary key for CaseDetail table

        public int CaseSessionId { get; set; } //Foreign key that links each CaseDetail to CaseConfiguration

        [ForeignKey("CaseSessionId")]
        public CaseConfiguration? CaseConfiguration { get; set; } //Navigation property that allows access to parent CaseConfiguration

        public string KeyName { get; set; } = string.Empty; //Unique key name for converting row => dictionary


        //Later features that i want to add including data for the cases that can be tracked
        /*
            public int NumberPaperbackPerTitle { get; set; } //Holds value for number paperback per title

            public int NumberPaperbackTitle { get; set; } //Holds number of paperback titles desired

            public int NumberHardcoverPerTitle { get; set; } //Holds value for number hardcover per title

            public int NumberHardcoverTitle { get; set; } //Holds number of hardcover titles desired

            public int TotalNumberTitles { get; set; } //Holds total number of titles

            public int TotalNumberBooks { get; set; } //Holds total number of books

            public int TitlesPerCase { get; set; } //Holds number of titles per case
        */
    }
}

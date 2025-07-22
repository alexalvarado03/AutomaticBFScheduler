using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*******************************
 Code written by: Alex Alvarado
 This code is for Phoenix Book Company LLC.
 Last Edited: 5/29/2025
 ******************************/

namespace BFConfigApp
{
    public enum Infrastructure
    {
        Small,
        Large,
        Custom
    }

    public enum TypeOfCase
    {
        Chapter,
        EarlyChapter,
        Nonfiction,
        LevelReader,
        New,
        Picture,
        Activity,
        Cookbook,
        Spanish,
        MiddleSchool,
        Highschool,
        Other
    }

    public class UserSession
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
    }

    //This class will hold the data objects for building a configuration
    public class CaseBuildingUserSession
    {
        public Dictionary<string, int> AllCaseNum { get; set; } = new(); //holds the case type as key and number of those cases as value

        public int TotalCaseNum { get; set; }   //Holds the total number of cases for this configuration

        public string Linens { get; set; } = string.Empty; //uses string as number of linens because can have >10 **Will be configured in later logic of app**

        public int MinCashRange { get; set; } //int value to hold Min Cash

        public int MaxCashRange { get; set; } //int value to hold max cash

        public bool IsTableTop { get; set; } //bool to say if the fair is table top fair

        public Infrastructure selectedInfra { get; set; } //enum that holds the infrastructure value

        public Dictionary<string, CaseTypeObject> CasesDataHolder { get; set; } = new(); //Dictionary to hold case object **Each case will need its own UNIQUE name**

        public string ConfigurationName { get; set; } = string.Empty; // holds the name of the configuration
    }

    public class CaseTypeObject
    {
        public TypeOfCase CaseType { get; set; } // Holds the type of case

        public string CaseName { get; set; } = string.Empty; //Holds the name of case

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

using System.Security.Cryptography.Pkcs;
using System;
using BFConfigApp.Data;
using BFConfigApp.Data.AppData;
using BFConfigApp.Data.Models;

namespace BFConfigApp.CoreServices
{
    public class SaveManager
    {

        //Responsible for saving each case configuration after it is created
        public static void SaveCaseConfig()
        {
            using var db = new DatabaseContext();

            var config = new CaseConfiguration
            {
                ConfigId = SessionManager.CurrentCaseSession.ConfigurationId,

                //TODO: Eventually want to add more data tracking this part of the save needs to change as well to include other data transfers
                CaseDetails = SessionManager.CurrentCaseSession.CasesDataHolder.Select(kvp => new CaseDetail 
                {
                    CaseName = kvp.Key, //the key of the KVP(Key Value Pair) is changed into the case name
                    CaseType = kvp.Value.CaseType // the CaseType of the KVP is changed into CaseType (Not real change but data is trasnferred to list)
                }).ToList(),

                AllCaseNum = SessionManager.CurrentCaseSession.AllCaseNum,

                TotalCaseNum = SessionManager.CurrentCaseSession.TotalCaseNum,

                Linens = SessionManager.CurrentCaseSession.Linens,

                MinCashRange = SessionManager.CurrentCaseSession.MinCashRange,

                MaxCashRange = SessionManager.CurrentCaseSession.MaxCashRange,

                IsTableTop = SessionManager.CurrentCaseSession.IsTableTop,

                SelectedInfra = SessionManager.CurrentCaseSession.SelectedInfra,

                ConfigurationName = SessionManager.CurrentCaseSession.ConfigurationName,

                UserId = SessionManager.CurrentSession.UserId,

            };
            db.CaseConfigurations.Add(config);
            db.SaveChanges();
        }
    }
}

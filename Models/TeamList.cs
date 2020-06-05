using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationASPNET_Cloud.Models
{
    public class TeamList
    {
        public int PIDNumber { get; set; }
        public string SOWNumber { get; set; }
        public string PeopleSoftID { get; set; }
        public string OID { get; set; }
        public string Name { get; set; }
        public string SupervisorName { get; set; }

        public string SapientTitle { get; set; }

        public string Role { get; set; }
        public string EndDate { get; set; }

        public string EmploymentType { get; set; }

        public string ProjectName { get; set; }

        public string TechnicalDomain { get; set; }
        public string SapientExp { get; set; }

        public string RBSExp { get; set; }

        public string CurrentITExp { get; set; }

        public string TotalITExpAtTheTimeOfRBSJoining { get; set; }
        public string ProjectType { get; set; }
        public string ProjectNameRBS { get; set; }
        public string DOJSapient { get; set; }
        public string DOJRBS { get; set; }
        public string ContactNumber { get; set; }
        public string DOB { get; set; }


        public TeamList() { }


        public TeamList(int pIDNumber, string sOWNumber, string peopleSoftID, string oid, string name, string supervisorName,
            string sapientTitle, string role, string endDate, string employmentType, string projectName, 
            string technicalDomain, string sapientExp, string rBSExp, string currentITExp, 
            string totalITExpAtTheTimeOfRBSJoining, string projectType, string projectNameRBS, 
            string dOJSapient, string dOJRBS, string contactNumber, string dOB)
        {
            this.PIDNumber = pIDNumber;
            this.SOWNumber = sOWNumber;
            this.PeopleSoftID = peopleSoftID;
            this.OID = oid;
            this.Name = name;
            this.SupervisorName = supervisorName;
            this.SapientTitle = sapientTitle;
            this.Role = role;
            this.EndDate = endDate;
            this.EmploymentType = employmentType;
            this.ProjectName = projectName;
            this.TechnicalDomain = technicalDomain;
            this.SapientExp = sapientExp;
            this.RBSExp = rBSExp;
            this.CurrentITExp = currentITExp;
            this.TotalITExpAtTheTimeOfRBSJoining = totalITExpAtTheTimeOfRBSJoining;
            this.ProjectType = projectType;
            this.ProjectNameRBS = projectNameRBS;
            this.DOJSapient = dOJSapient;
            this.DOJRBS = dOJRBS;
            this.ContactNumber = contactNumber;
            this.DOB = dOB;

        }

        public static List<TeamList> GetTeamsData()
        {
            return new List<TeamList>
            {
                new TeamList(1,"RBS1TQ0002226","8065744","394328","ABCD","XYZ","Manager Program Management","PM","Till SOW End","Permanant","Cloud AWS","PM","8 years","1 year 5 months", "11 years","9 years","XYZ123","T&TR","05/20/2010","01/01/2018","4554646","****"),
                new TeamList(2,"RBS1TQ0002226","9065542","224334","EFGH","XYZ","Manager Program Management","PM","Till SOW End","Permanant","Cloud AWS","PM","8 years","1 year 5 months", "11 years","9 years","XYZ123","T&TR","05/20/2010","01/01/2018","4554646","****"),
                new TeamList(3,"RBS1TQ0002226","8065777","394355","IJKL","XYZ","Manager Program Management","PM","Till SOW End","Permanant","Cloud AWS","PM","8 years","1 year 5 months", "11 years","9 years","XYZ123","T&TR","05/20/2010","01/01/2018","4554646","****"),
                new TeamList(4,"RBS1TQ0002226","5565711","394334","MNOP","XYZ","Manager Program Management","PM","Till SOW End","Permanant","Cloud AWS","PM","8 years","1 year 5 months", "11 years","9 years","XYZ123","T&TR","05/20/2010","01/01/2018","4554646","****"),
                new TeamList(5,"RBS1TQ0002226","4465700","394378","QWRS","XYZ","Manager Program Management","PM","Till SOW End","Permanant","Cloud AWS","PM","8 years","1 year 5 months", "11 years","9 years","XYZ123","T&TR","05/20/2010","01/01/2018","4554646","****"),
                new TeamList(6,"RBS1TQ0002226","3365123","394387","UVWX","XYZ","Manager Program Management","PM","Till SOW End","Permanant","Cloud AWS","PM","8 years","1 year 5 months", "11 years","9 years","XYZ123","T&TR","05/20/2010","01/01/2018","4554646","****"),
                new TeamList(7,"RBS1TQ0002226","8065654","394366","YZAB","XYZ","Manager Program Management","PM","Till SOW End","Permanant","Cloud AWS","PM","8 years","1 year 5 months", "11 years","9 years","XYZ123","T&TR","05/20/2010","01/01/2018","4554646","****"),
                new TeamList(8,"RBS1TQ0002226","8065234","394334","WRTY","XYZ","Manager Program Management","PM","Till SOW End","Permanant","Cloud AWS","PM","8 years","1 year 5 months", "11 years","9 years","XYZ123","T&TR","05/20/2010","01/01/2018","4554646","****"),
                new TeamList(9,"RBS1TQ0002226","8065888","394350","YTTY","XYZ","Manager Program Management","PM","Till SOW End","Permanant","Cloud AWS","PM","8 years","1 year 5 months", "11 years","9 years","XYZ123","T&TR","05/20/2010","01/01/2018","4554646","****"),
                new TeamList(10,"RBS1TQ0002226","80657230","394326","FGFG","XYZ","Manager Program Management","PM","Till SOW End","Permanant","Cloud AWS","PM","8 years","1 year 5 months", "11 years","9 years","XYZ123","T&TR","05/20/2010","01/01/2018","4554646","****"),

            };
        }
    }
}

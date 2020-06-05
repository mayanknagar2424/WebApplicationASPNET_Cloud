using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationASPNET_Cloud.Models
{
    public class TeamListAndDataModel
    {
       public List<TeamList> TeamListData { get; set; }

        //pagination
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int PagerCount { get; set; }

    }
}

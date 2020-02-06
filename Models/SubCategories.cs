using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dmart.Models
{
    public class SubCategories:Categories
    {
   
        public int Scid { get; set; }
        public string Scname { get; set; }
        public string Scdes { get; set; }

        public SubCategories() { }

        public SubCategories(int cid, string cname, string cdetails, int id, string name, string details) : base(cid, cname, cdetails)
        {
            this.Scid = id;
            this.Scname = name;
            this.Scdes = details;

        }
    }
}

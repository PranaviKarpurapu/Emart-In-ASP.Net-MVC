using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dmart.Models
{
    public abstract class Categories
    {
       [Key]
        public int Cid { get; set; }
        public string CName { get; set; }
        public string CDetails { get; set; }

        public Categories() { }
        public Categories(int id, string name, string details)
        {
            this.Cid = id;
            this.CName = name;
            this.CDetails = details;

        }

    }
}

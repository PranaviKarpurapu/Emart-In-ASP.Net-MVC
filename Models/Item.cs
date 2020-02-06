using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dmart.Models
{
    public class Item :SubCategories
    {
        [Key]
        public int ItemId { get; set; }
        public int CatId { get; set; }
        public int SubCatId { get; set; }
        public int Price { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int StockNumber { get; set; }
        public string Remarks { get; set; }

        public Item() { }

        public Item(int cid, string cname, string cdetails, int scid, string scname, string scdetails, int iid,int price,string iname,string ides,int istock,string irem):base(cid, cname, cdetails,scid,scname,scdetails)

        {
            this.ItemId = iid;
            this.Price = price;
            this.ItemName = iname;
            this.ItemDescription = ides;
            this.StockNumber = istock;
            this.Remarks = irem;
        }
    }
}
 
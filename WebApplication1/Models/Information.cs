using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Information
    {
        public Int32 Id { get; set; }
        [Display(Name = "Ten")]
        public string Name { get; set; }
        public Int32 Age { get; set; }
        public Boolean Status { get; set; }

    }

    public class ListModel<Information>
    {
        public List<Information> Items { get; set; }

        public ListModel(List<Information> list)
        {
            Items = list;
        }
    }
}

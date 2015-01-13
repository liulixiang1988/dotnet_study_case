using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name="电影名")]
        public string Title { get; set; }

        [Display(Name = "发布日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "类别")]
        public string Genre { get; set; }

        [Display(Name = "价格")]
        public decimal Price { get; set; }
    }
}
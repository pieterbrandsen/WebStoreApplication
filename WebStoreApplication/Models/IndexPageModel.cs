using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class IndexPageModel : PagesModel
    {
        // Header //
        [DisplayName("Header Title")]
        public string HeaderTitle { get; set; }
        public string HeaderDescription { get; set; }
        public string HeaderPhotoPath { get; set; }

        // Products Titles's //
        [DisplayName("Top Product List")]
        public string TopProductName1 { get; set; }
        public string TopProductName2 { get; set; }
        public string TopProductName3 { get; set; }
        [DisplayName("Trending Product List")]
        public string TrendingProductName1 { get; set; }
        public string TrendingProductName2 { get; set; }
        public string TrendingProductName3 { get; set; }


    }
}

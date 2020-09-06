using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class ProductModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [DisplayName("Additional Information")]
        public string AdditionalInformation { get; set; }
        public double Price { get; set; }
        public bool Visible { get; set; }
        public string FilePath { get; set; }
        public string FilePath2 { get; set; }
        public string FilePath3 { get; set; }
        public string FilePath4 { get; set; }
        public string FilePath5 { get; set; }
    }
}

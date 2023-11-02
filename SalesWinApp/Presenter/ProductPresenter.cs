using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWinApp.Presenter
{
    public class ProductPresenter
    {
        [DisplayName("Product ID")]
        public int ProductId { get; set; }

        [DisplayName("CategoryId")]
        public string CategoryId { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        
        [DisplayName("Weight")]
        public string Weight { get; set; }

        [DisplayName("Unit Price")]
        public decimal UnitPrice { get; set; }

        [DisplayName("Units In Stock")]
        public int UnitsInStock { get; set; }

    }
}

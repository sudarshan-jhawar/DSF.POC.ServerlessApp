using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSF.POC.Serverless.Library.Entities
{
    public record Product(int ProductId,string ProductName,string ProductDescription);
    //public class Product
    //{
    //    public int ProductId { get; set; }
    //    public string ProductName { get; set; }
    //    public string ProductDescription { get; set; }

    //}
}

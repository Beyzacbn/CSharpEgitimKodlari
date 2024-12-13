using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        //birincil anahtar ve otomatik artan olduğunu bildirmek adına
        //sınıfın adı birebir aynı yazılıp sonuna Id getirilmeli
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public bool CategoryStatus { get; set; }

        public List<Product> Products { get; set; }


    }
}

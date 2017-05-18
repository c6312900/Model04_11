using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model04_09.DAL;
using Model04_09.ViewModels;

namespace Model04_09.Models
{
   public class ProductSystem
    {

        public ProductViewModel GetProductID(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.ProductID == id
                        select new ProductViewModel {
                            ProductID =p.ProductID,
                            ProductName =p.ProductName,
                            UnitPrice =p.UnitPrice
                        };

            var result = query.First();
            return result;
        }



        public IEnumerable<Product> GetProductsByCategoryID(int Id)
        {
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.CategoryID == Id
                        select p;

            var result = query.ToList();
            return result;
        }
    }


    
}

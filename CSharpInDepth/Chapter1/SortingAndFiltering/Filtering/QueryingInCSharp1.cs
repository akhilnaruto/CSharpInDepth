using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInDepth.Chapter1.SortingAndFiltering.Filtering
{
   public class QueryingInCSharp1
   {
     public void FilterProducts()
     {
      var products = Product.GetSamplesProducts();
       foreach (Product product in products)
       {
         if (product.Price > 10m)
         {
           Console.WriteLine(product);
         }
       }

     }
  }
}

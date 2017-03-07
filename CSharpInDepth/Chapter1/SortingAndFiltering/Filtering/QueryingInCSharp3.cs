using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInDepth.Chapter1.SortingAndFiltering.Filtering
{
  public class QueryingInCSharp3
  {
    public void FilterProducts()
    {
      List<Product> products = Product.GetSamplesProducts();

      foreach (Product product in products.Where(p => p.Price > 10m))
      {
        Console.WriteLine(product);
      }
    }
  }
}

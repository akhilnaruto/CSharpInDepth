using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInDepth.Chapter1.SortingAndFiltering
{
  public class ProductSortingInCSharp3
  {
    public void CompareProducts()
    {
      List<Product> products = Product.GetSamplesProducts();
      products.Sort((x,y) => x.Name.CompareTo(y.Name));
      foreach (Product  product in products)
      {
        Console.WriteLine(product);
      }
    }

    public void OrderProducts()
    {
      List<Product> products = Product.GetSamplesProducts();
      foreach (Product product in products.OrderBy(p =>p.Name))
      {
        Console.WriteLine(product);
      }
    }
  }


}

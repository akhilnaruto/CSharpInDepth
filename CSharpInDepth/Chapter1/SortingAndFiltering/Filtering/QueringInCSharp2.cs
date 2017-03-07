using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInDepth.Chapter1.SortingAndFiltering.Filtering
{
  public class QueringInCSharp2
  {
    public void FilterProducts()
    {
      List<Product> products = Product.GetSamplesProducts();

      Predicate<Product> test = delegate(Product p) { return p.Price > 10m; };
      List<Product> matches = products.FindAll(test);

      Action<Product> print = Console.WriteLine;
      matches.ForEach(print);
    }

    public void FilterProductsV1()
    {
      List<Product> products = Product.GetSamplesProducts();

      products.FindAll(
        delegate(Product p)
        {
          return p.Price > 10m;
        }).ForEach(Console.WriteLine);
    }
  }
}

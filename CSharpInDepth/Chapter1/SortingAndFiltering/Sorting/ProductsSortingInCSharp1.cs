using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInDepth.Chapter1.SortingAndFiltering
{
  public class ProductsSortingInCSharp1
  {
    private string name;
    public string Name { get { return name; } }

    private decimal price;
    public decimal Price { get { return price; } }

    public ProductsSortingInCSharp1(string name , decimal price)
    {
      this.name = name;
      this.price = price;
    }

    public static ArrayList GetSampleProducts()
    {
      ArrayList products = new ArrayList();
      products.Add(new ProductsSortingInCSharp1("ABCDE", 8.11m));
      products.Add(new ProductsSortingInCSharp1("DEFGU", 8.11m));
      products.Add(new ProductsSortingInCSharp1("HJII", 8.11m));
      products.Add(new ProductsSortingInCSharp1("IKKK", 8.11m));
      products.Add(new ProductsSortingInCSharp1("JJJ", 8.11m));

      return products;
    }

    public static void PrintOrderedSampleProducts()
    {
      ArrayList products = ProductsSortingInCSharp1.GetSampleProducts();
      products.Sort(new ProductNameComparer_1());
      foreach(ProductsSortingInCSharp1 product in products)
      {
        Console.WriteLine(product.name);
      }
    }

  }

  class ProductNameComparer_1 : IComparer
  {
    public int Compare(object x, object y)
    {
      ProductsSortingInCSharp1 first = (ProductsSortingInCSharp1)x;
      ProductsSortingInCSharp1 second = (ProductsSortingInCSharp1)y;

      return first.Name.CompareTo(second.Name);
    }
  }
}

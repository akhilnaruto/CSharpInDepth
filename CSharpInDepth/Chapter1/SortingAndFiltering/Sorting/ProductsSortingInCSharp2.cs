using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInDepth.Chapter1.SortingAndFiltering
{
  public class ProductsSortingInCSharp2
  {
    private string name;
    public string Name { get { return name; } }

    private decimal price;
    public decimal Price { get { return price; } }

    public ProductsSortingInCSharp2(string name , decimal price)
    {
      this.name = name;
      this.price = price;
    }

    public static List<ProductsSortingInCSharp2> GetSampleProducts()
    {
      List<ProductsSortingInCSharp2> products = new List<ProductsSortingInCSharp2>();
      products.Add(new ProductsSortingInCSharp2("dasdasd", 8.11m));
      products.Add(new ProductsSortingInCSharp2("dsadasd", 8.11m));
      products.Add(new ProductsSortingInCSharp2("dadadwerrsdasd", 8.11m));
      products.Add(new ProductsSortingInCSharp2("rweyrtye", 8.11m));
      products.Add(new ProductsSortingInCSharp2("adadsdad", 8.11m));

      return products;
    }

    public static void PrintOrderedSampleProducts()
    {
      List<ProductsSortingInCSharp2> products = ProductsSortingInCSharp2.GetSampleProducts();
      products.Sort(new ProductNameComparer());
      foreach(ProductsSortingInCSharp2 product in products)
      {
        Console.WriteLine(product.Name);
      }
    }

    public static void PrintOrderedProductsUsingDelegates()
    {
      List<ProductsSortingInCSharp2> products = ProductsSortingInCSharp2.GetSampleProducts();

      products.Sort(delegate (ProductsSortingInCSharp2 first, ProductsSortingInCSharp2 second)
      {
        return first.Name.CompareTo(second.Name);
      });
    }
  }

  class ProductNameComparer : IComparer<ProductsSortingInCSharp2>
  {
    public int Compare(ProductsSortingInCSharp2 first, ProductsSortingInCSharp2 second)
    {
      return first.Name.CompareTo(second.Name);
    }
  }
}


using G_NET_60_Linq_1;
using static G_NET_60_Linq_1.Source;

internal class Program
{
    static void Main(string[] args)
    {
        #region Question01
        ////1. Get all products from the "Seafood" category. Print each product's name and price
        //var Seafood = ProductList.Where(P=>P.Category == "Seafood")
        //                            .Select(P=> new {  P.ProductName , P.UnitPrice} );


        //foreach (var i in Seafood)
        //{
        //    Console.WriteLine(i);

        //}



        //Query Syntax

        //Seafood = from p in ProductList
        //          where p.Category == "Seafood"
        //          select new { p.ProductName, p.UnitPrice };




        #endregion

        #region Question02
        //2. Get a list of only the product names from ProductList. Print each name.

        //var productnames = ProductList.Select(p =>  p.ProductName );

        //foreach(var i in productnames)
        //{

        //    Console.WriteLine(i);

        //}




        //productnames = from p in ProductList
        //               select p.ProductName;




        #endregion

        #region Question03

        //Sort all products by UnitPrice (ascending). Print each product's name and price.

        //var Sortproducts = ProductList.OrderBy(P => P.UnitPrice).Select(p => new { p.ProductName, p.UnitPrice });

        //foreach(var i in Sortproducts)
        //{

        //    Console.WriteLine(i);


        //}


        //Sortproducts = from p in ProductList
        //               orderby p.UnitPrice
        //               select new
        //               {
        //                   p.ProductName,
        //                   p.UnitPrice
        //               };




        #endregion

        #region Question04
        //Get all products where UnitPrice is between 10 and 30

        //var Products = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30).OrderBy(p=> p.UnitPrice);


        //foreach(var i in Products)
        //{
        //    Console.WriteLine(i.UnitPrice);


        //}


        //var products = from p in ProductList

        // where p.UnitPrice >= 10 && p.UnitPrice <= 30
        // select p;

        //foreach (var product in products)
        //{
        //    Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
        //}




        #endregion




    }
}


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

        var productnames = ProductList.Select(p =>  p.ProductName );

        foreach(var i in productnames)
        {

            Console.WriteLine(i);

        }




        productnames = from p in ProductList
                       select p.ProductName;




        #endregion

    }
}

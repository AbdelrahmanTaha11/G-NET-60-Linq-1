
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

        #region Question05

        //Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.

        // var ProductInStock = ProductList.Where(p => p.UnitsInStock > 1 && p.Category == "Condiments");


        //ProductInStock = from p in ProductList
        //                  where p.UnitPrice > 1
        //                  where p.Category == "Condiments"
        //                  select p;

        // foreach(var i in ProductInStock)
        // {
        //     Console.WriteLine(i);

        // }

        #endregion

        #region Question06

        /*
         * 6. Create a new anonymous type with three properties:
        ● Name → the product name
        ● Price → the unit price
        ● StockStatus → a string: "Available" if UnitsInStock > 0,
        otherwise "Out of Stock"
        ● Print the result.
         
         */

        //var result = ProductList.Select(p => new {Name= p.ProductName , Price = p.UnitPrice,
        //                                            StockStatus= p.UnitsInStock > 0 ? "Available" : "Out of Stock" });

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}






        #endregion

        #region Question07
        //7. Print each product's name along with its position (1-based) in the list. Expected format: 1.Chai, 2.Chang, etc.

        //var result = ProductList.Select((p, index) => new { Position = index + 1, Name = p.ProductName });

        //foreach (var item in result) {
        //    Console.WriteLine($"{item.Position}.{item.Name}");
        //}
        #endregion

        #region Question08
        //8. Sort ProductList by Category ascending, then within each   category, sort by UnitPrice descending.

        //var result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

        //foreach(var i in result)
        //{

        //    Console.WriteLine($"{i.Category} , {i.UnitPrice}");

        //}


        #endregion

        #region Question09

        //9. Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.


        //var reault = ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock > 1).
        //                                                               Select(p => new { name = p.ProductName, Stock = p.UnitsInStock > 1 });

        //foreach(var i in reault)
        //{
        //    Console.WriteLine(i);


        //}

        #endregion

        #region Question10

        /*10. Using QUERY SYNTAX with a compound from clause, list
            all orders placed in 1997 or later showing CustomerID and
            OrderDate.*/


        //var result = from c in CustomerList
        //             from o in c.Orders
        //             where o.OrderDate >= new DateTime(1997, 1, 1)
        //             select new
        //             {
        //                 c.CustomerID,
        //                 o.OrderDate
        //             };
        //foreach (var order in result)
        //{
        //    Console.WriteLine(order);

        //}


        #endregion




    }
}

using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace LINQ
{
    class Program
    {
        /* Practice your LINQ!
         * You can use the methods in Data Loader to load products, customers, and some sample numbers
         * 
         * NumbersA, NumbersB, and NumbersC contain some ints
         * 
         * The product data is flat, with just product information
         * 
         * The customer data is hierarchical as customers have zero to many orders
         */
        static void Main()
        {
            //PrintOutOfStock();
            //InStockMoreThan3();
            //WashingtonCustomerOrder();
            //ProductNames();
            IncreasedProductPrices();
            Console.ReadLine();
        }

        //1. Find all products that are out of stock.
        private static void PrintOutOfStock()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.Where(p => p.UnitsInStock == 0);
            var results = from p in products
                          where p.UnitsInStock == 0
                          select p;

            foreach (var product in results)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        // 2. Find all products that are in stock and cost more than 3.00 per unit.
        private static void InStockMoreThan3()
        {
            var products = DataLoader.LoadProducts();

            var results = products.Where(p => p.UnitsInStock > 0  && p.UnitPrice > 3);

            foreach (var product in results)
            {
                Console.WriteLine("{0} has {1} in stock with unit price {2}", product.ProductName, product.UnitsInStock, product.UnitPrice);
            }
        }

        //3. Find all customers in Washington, print their name then their orders. (Region == "WA")
        private static void WashingtonCustomerOrder()
        {
            var customers = DataLoader.LoadCustomers();

            var results = from c in customers
                where c.Region == "WA"
                select c;

            foreach (var customer in results)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Customer: {0}, has the following orders:", customer.CompanyName);
                Console.ResetColor();
                foreach (var order in customer.Orders)
                {
                   
                    Console.WriteLine("ID: {0}, DATE: {1}, TOTAL: {2}", order.OrderID, order.OrderDate, order.Total);
                }
            }
        }

        //4. Create a new sequence with just the names of the products.
        private static void ProductNames()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                select p.ProductName;

            foreach (var product in results)
            {
                Console.WriteLine(product);
            }
        }

        //5. Create a new sequence of products and unit prices where the unit prices are increased by 25%.
        private static void IncreasedProductPrices()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                select new
                {
                    p.ProductName,
                    UnitPrice = p.UnitPrice/4 + p.UnitPrice
                };

            foreach (var product in results)
            {
                Console.WriteLine("Product Name: {0}\n Unit Price: {1}", product.ProductName, product.UnitPrice);
            }
        }
        //6. Create a new sequence of just product names in all upper case.

        //7. Create a new sequence with products with even numbers of units in stock.

        //8. Create a new sequence of products with ProductName, Category, and rename UnitPrice to Price.

        //9. Make a query that returns all pairs of numbers from both arrays such that the number from numbersB is less than the number from numbersC.
        
        //10. Select CustomerID, OrderID, and Total where the order total is less than 500.00.
       
        //11. Write a query to take only the first 3 elements from NumbersA.
        
        //12. Get only the first 3 orders from customers in Washington.
        
        //13. Skip the first 3 elements of NumbersA.
        
        //14. Get all except the first two orders from customers in Washington.
        
        //15. Get all the elements in NumbersC from the beginning until an element is greater or equal to 6.
        
        //16. Return elements starting from the beginning of NumbersC until a number is hit that is less than its position in the array.
        
        //17. Return elements from NumbersC starting from the first element divisible by 3.
        
        //18. Order products alphabetically by name.
        
        //19. Order products by UnitsInStock descending.
        
        //20. Sort the list of products, first by category, and then by unit price, from highest to lowest.
        
        //21. Reverse NumbersC.
        
        //22. Display the elements of NumbersC grouped by their remainder when divided by 5.
        
        //23. Display products by Category.
        
        //24. Group customer orders by year, then by month.
        
        //25. Create a list of unique product category names.
        
        //26. Get a list of unique values from NumbersA and NumbersB.
        
        //27. Get a list of the shared values from NumbersA and NumbersB.
        
        //28. Get a list of values in NumbersA that are not also in NumbersB.
        
        //29. Select only the first product with ProductID = 12(not a list).
        
        //30. Write code to check if ProductID 789 exists.
        
        //31. Get a list of categories that have at least one product out of stock.
        
        //32. Determine if NumbersB contains only numbers less than 9.
        
        //33. Get a grouped a list of products only for categories that have all of their products in stock.
        
        //34. Count the number of odds in NumbersA.
        
        //35. Display a list of CustomerIDs and only the count of their orders.
        
        //36. Display a list of categories and the count of their products.
        
        //37. Display the total units in stock for each category.
        
        //38. Display the lowest priced product in each category.
        
        //39. Display the highest priced product in each category.
        
        //40. Show the average price of product for each category.
    }
}

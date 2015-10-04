using System;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

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
            // 1
            //PrintOutOfStock();

            // 2
            //InStockMoreThan3();

            // 3
            //WashingtonCustomerOrder();

            // 4
            //ProductNames();

            // 5
            //IncreasedProductPrices();

            // 6
            //UpperCaseProductNames();

            // 7
            //ProductsWithEvenNumInStock();

            // 8
            //RenameUnitPrice();

            // 9
            //PairsFromArrays();

            // 10
            //SelectWhereOrderTotalLess500();

            // 11
            //First3Elements();

            // 12
            //ThreeOrdersFromWaCustomers();

            // 13
            //Skip3Elements();

            // 14
            //SkipFirstTwoOrders();

            // 15
            //ElementUntilGreaterThan6();

            // 16
            //LessThanArrayPosition();

            // 17
            //DivisbleBy3StartingPosition();

            // 18
            //AlphabeticallyOrderedProduct();

            // 19
            //OrderedByAmountInStock();

            // 20 
            //OrderedByCategoryThenUnitPrice();

            // 21
            //ReverseC();

            // 22
            //GroupByRemainder();

            // 23
            //OrderedByCategory();

            // 24


            // 25
            //CategoryList();

            // 26
            //UniqueNumANumB();

            // 27
            //IntersectNumANumB();

            // 28
            //NumANotInNumB();

            // 29
            //ProductID12();

            // 30


            // 31
            //CategoriesItemOutOfStock();

            // 32
            //AllNumBLessThan9();

            // 33
            //AllProductInCategoryInStock();

            // 34
            //CountOdds();

            // 35
            //CustomerIDsAndOrders();

            // 36
           

            // 37


            // 38


            // 39


            // 40


            // Keep console open
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
        private static void UpperCaseProductNames()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                select p.ProductName.ToUpper();

            foreach (var product in results)
            {
                Console.WriteLine(product);
            }
            ;
        }

        //7. Create a new sequence with products with even numbers of units in stock.
        private static void ProductsWithEvenNumInStock()
        {
            var products = DataLoader.LoadProducts();

            var results = products.Where(p => p.UnitsInStock%2 == 0 && p.UnitsInStock != 0).Select(p => p.ProductName);
               
            foreach (var prod in results)
            {
                Console.WriteLine(prod);
            }
        }

        //8. Create a new sequence of products with ProductName, Category, and rename UnitPrice to Price.
        private static void RenameUnitPrice()
        {
            var products = DataLoader.LoadProducts();

            var results = products.Select(p => new
            {
                p.ProductName,
                p.Category,
                Price = p.UnitPrice
            });

            foreach (var product in results)
            {
                Console.WriteLine("Product Name: {0}, Category: {1}, Price: {2}", product.ProductName, product.Category, product.Price);
            }

        }

        //9. Make a query that returns all pairs of numbers from both arrays such that the number from numbersB is less than the number from numbersC.
        private static void PairsFromArrays()
        {
            var numbersB = DataLoader.NumbersB;
            var numbersC = DataLoader.NumbersC;

            var results = from b in numbersB
                from c in numbersC
                where b < c
                select new
                {
                    b,
                    c
                };

            foreach (var item in results)
            {
                Console.WriteLine("{0},{1}",item.b, item.c);
            }

        }    
    
        //10. Select CustomerID, OrderID, and Total where the order total is less than 500.00.
        private static void SelectWhereOrderTotalLess500()
        {
            var customers = DataLoader.LoadCustomers();

            var results = from c in customers
                from o in c.Orders
                where o.Total < 500
                select new
                {
                    c.CustomerID,
                    o.OrderID,
                    o.Total
                };

            foreach (var customer in results)
            {
                Console.WriteLine("CustomerID: {0}, OrderID: {1}, Total: {2}", customer.CustomerID, customer.OrderID, customer.Total);
            }
        }

        //11. Write a query to take only the first 3 elements from NumbersA.
        private static void First3Elements()
        {
            var numbersA = DataLoader.NumbersA;

            var results = numbersA.Take(3);

            foreach (var num in results)
            {
                Console.WriteLine(num);
            }
        }
        
        //12. Get only the first 3 orders from customers in Washington.
        private static void ThreeOrdersFromWaCustomers()
        {
            var customers = DataLoader.LoadCustomers();

            var results = from c in customers
                where c.Region == "WA"
                from o in c.Orders.Take(3)
                select new
                {
                    c,
                    o
                };

            foreach (var customer in results)
            {
                Console.WriteLine("Customer: {0},  Order: {1}", customer.c.CustomerID, customer.o.OrderID);
            }
        }

        //13. Skip the first 3 elements of NumbersA.
        private static void Skip3Elements()
        {
            var numbersA = DataLoader.NumbersA;

            var results = numbersA.SkipWhile((number, index) => index < 3);

            foreach (var num in results)
            {
                Console.WriteLine(num);
            }
        }

        //14. Get all except the first two orders from customers in Washington.
        private static void SkipFirstTwoOrders()
        {
            var customers = DataLoader.LoadCustomers();

            var results = from c in customers
                where c.Region == "WA"
                from o in c.Orders.SkipWhile((n, index) => index < 2)
                select new
                {
                    c.CustomerID,
                    o
                };

            foreach (var item in results)
            {
                Console.WriteLine("Customer ID: {0} Order: {1}", item.CustomerID, item.o.OrderID);
            }

        }

        //15. Get all the elements in NumbersC from the beginning until an element is greater or equal to 6.
        private static void ElementUntilGreaterThan6()
        {
            var numbersC = DataLoader.NumbersC;

            var results = numbersC.TakeWhile(n => n <= 6);

            foreach (var num in results)
            {
                Console.WriteLine(num);
            }
        }

        //16. Return elements starting from the beginning of NumbersC until a number is hit that is less than its position in the array.
        private static void LessThanArrayPosition()
        {
            var numbersC = DataLoader.NumbersC;

            var results = numbersC.TakeWhile((number,index) => number > index);

            foreach (var num in results)
            {
                Console.WriteLine(num);
            }
        }

        //17. Return elements from NumbersC starting from the first element divisible by 3.
        private static void DivisbleBy3StartingPosition()
        {
            var numbersC = DataLoader.NumbersC;

            var results = numbersC.SkipWhile(n => n % 3 != 0);

            foreach (var num in results)
            {
                Console.WriteLine(num);
            }
        }

        //18. Order products alphabetically by name.
        private static void AlphabeticallyOrderedProduct()
        {
            var products = DataLoader.LoadProducts();

            var results = products.OrderBy(p => p.ProductName);

            foreach (var product in results)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        //19. Order products by UnitsInStock descending.
        private static void OrderedByAmountInStock()
        {
            var products = DataLoader.LoadProducts();

            var results = products.OrderByDescending(p => p.UnitsInStock);

            foreach (var product in results)
            {
                Console.WriteLine("Product: {0} - Stock: {1}", product.ProductName, product.UnitsInStock);
            }
        }

        //20. Sort the list of products, first by category, and then by unit price, from highest to lowest.
        private static void OrderedByCategoryThenUnitPrice()
        {
            var products = DataLoader.LoadProducts();

            var results = products.OrderBy(p=>p.Category).ThenByDescending(p=>p.UnitPrice);

            foreach (var product in results)
            {
                Console.WriteLine("Category: {0}, Name: {1}, Unit Price: {2}", product.Category, product.ProductName, product.UnitPrice);
            }  
        }

        //21. Reverse NumbersC.
        private static void ReverseC()
        {
            var numbersC = DataLoader.NumbersC;

            var results = numbersC.Reverse();

            foreach (var num in results)
            {
                Console.WriteLine(num);
            }
        }

        //22. Display the elements of NumbersC grouped by their remainder when divided by 5.
        private static void GroupByRemainder()
        {
            var numbersC = DataLoader.NumbersC;

            var results = from n in numbersC
                let r = n%5
                orderby r
                group n by r;

      foreach (var num in results)
      {
          Console.WriteLine("\nRemainder: {0}", num.Key);
          foreach (var n in num)
          {
                    Console.WriteLine("Number: {0}", n);
                }
      }
        }

        //23. Display products by Category.
        private static void OrderedByCategory()
        {
            var products = DataLoader.LoadProducts();

            var results = products.OrderBy(p => p.Category);

            foreach (var product in results)
            {
                Console.WriteLine("Category: {0}, Name: {1}", product.Category, product.ProductName);
            }
        }

        //24. Group customer orders by year, then by month.
        private static void CustomerOrderByYearByMonth()
        {
            var customers = DataLoader.LoadCustomers();

            var results = from c in customers
                select new
                {
                    company = c.CompanyName,
                    yearGroups = from o in c.Orders
                        group o by o.OrderDate.Year
                        into yg
                        select new
                        {
                            year = yg.Key,
                            monthGroups = from m in yg
                                group m by m.OrderDate.Month
                                into mg
                                select new
                                {
                                    month = mg.Key,
                                    orders = mg
                                }
                        }
                };

            /* foreach (var item in results)
             {
                 Console.WriteLine(item.company);

                 foreach (var year in item.yearGroups)
                 {
                     Console.WriteLine(year.year);
                 }
                     foreach (var month in item.Key)
                     {
                         Console.WriteLine();
                     }
                         foreach (var order in s)
                         {
                             Console.WriteLine();
                         }
             }*/
        }

        //25. Create a list of unique product category names.
        private static void CategoryList()
        {
            var products = DataLoader.LoadProducts();

            var results = products.Select(c => c.Category).Distinct().OrderBy(cat => cat);

            foreach (var category in results)
            {
                Console.WriteLine("Category: {0}", category);
            }
        }

        //26. Get a list of unique values from NumbersA and NumbersB.
        private static void UniqueNumANumB()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var results = numbersA.Concat(numbersB).Distinct();

            foreach (var num in results)
            {
                Console.WriteLine(num);
            }
        }

        //27. Get a list of the shared values from NumbersA and NumbersB.
        private static void IntersectNumANumB()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var results = numbersA.Intersect(numbersB);

            foreach (var num in results)
            {
                Console.WriteLine(num);
            }
        }

        //28. Get a list of values in NumbersA that are not also in NumbersB.
        private static void NumANotInNumB()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var results = numbersA.Except(numbersB);

            foreach (var num in results)
            {
                Console.WriteLine(num);
            }
        }

        //29. Select only the first product with ProductID = 12(not a list).
        private static void ProductID12()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                where p.ProductID == 12
                select p.ProductName;

            foreach (var item in results)
            {
                Console.WriteLine("{0}", item);
            }
        }

        //30. Write code to check if ProductID 789 exists.
        private static void ContainsProductID789()
        {
            var products = DataLoader.LoadProducts();

            
        }

        //31. Get a list of categories that have at least one product out of stock.
        private static void CategoriesItemOutOfStock()
        {
            var products = DataLoader.LoadProducts();

            var results = products.Where(p => p.UnitsInStock == 0).GroupBy(c => c.Category).Select(g => g.Key);

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

        }

        //32. Determine if NumbersB contains only numbers less than 9.
        private static void AllNumBLessThan9()
        {
            var numbersB = DataLoader.NumbersB;

            var result = numbersB.All(n => n < 9);

            Console.WriteLine(result);
        }

        //33. Get a grouped a list of products only for categories that have all of their products in stock.
        private static void AllProductInCategoryInStock()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products

                group p by p.Category
                into pCats
                          where pCats.All(x => x.UnitsInStock > 0)
                select new {pCats.Key, coll = pCats};
                    
                    
            foreach (var result in results)
            {
                Console.WriteLine("\n{0}", result.Key);
                foreach (var product in result.coll)
                {
                    Console.WriteLine("\n{0} - {1}", product.UnitsInStock, product.ProductName);
                }
            }


        }

        //34. Count the number of odds in NumbersA.
        private static void CountOdds()
        {
            var numbersA = DataLoader.NumbersA;

            var results = from n in numbersA
                where n%2 == 1
                select n;
            
            Console.WriteLine(results.Count());
            
        }

        //35. Display a list of CustomerIDs and only the count of their orders.
        private static void CustomerIDsAndOrders()
        {
            var customers = DataLoader.LoadCustomers();

            var results = from c in customers
                select new
                {
                    c.CustomerID,
                    orderCount = c.Orders.Count()
                };

            foreach (var customer in results)
            {
                Console.WriteLine("CustomerID: {0}. Order Count: {1}", customer.CustomerID, customer.orderCount);
            }
        }

        //36. Display a list of categories and the count of their products.
        private static void CategoriesAndProductCount()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                group p by new
                {
                    p.Category,
                    p.ProductID
                }
                into pCats
                select new
                {
                    Category = pCats.Key.Category,
                    ProductID = pCats.Key.ProductID,
                    Count = pCats.Count()
                };

            foreach (var categories in results)
            {
                Console.WriteLine("Category: {0}. Product Count: {1}", categories.Category, categories.Count);
            }
        }

        //37. Display the total units in stock for each category.

        //38. Display the lowest priced product in each category.

        //39. Display the highest priced product in each category.

        //40. Show the average price of product for each category.

    }
}

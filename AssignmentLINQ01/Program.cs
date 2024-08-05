using static AssignmentLINQ01.ListGenerator;
namespace AssignmentLINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //LINQ - Restriction Operators

            #region 1.Find all products that are out of stock.

            //var products = new List<Product>();


            //var outofstock = ProductsList.Where(p => p.UnitsInStock == 0);

            //foreach (var product in outofstock)
            //{
            //    Console.WriteLine($"{product.ProductName}");
            //}

            #endregion


            #region 2.Find all products that are in stock and cost more than 3.00 per unit.

            //var productsInStockProducts = ProductsList.Where(p => p.UnitsInStock > 0 && (dynamic)p.UnitPrice > 3.00m);

            //foreach (var product in productsInStockProducts)
            //{
            //    Console.WriteLine($"{product.ProductName}");

            //}



            #endregion


            #region 3. Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var shortNameDigits = Arr.Where((digit, index) => digit.Length < index);

            //foreach (var digit in shortNameDigits)
            //{
            //    Console.WriteLine($"{digit} has a shorter name than its value.");
            //}



            #endregion



            //LINQ - Ordering Operators


            #region 1. Sort a list of products by name

            //var products = new List<Product>();

            //var sortedProductsByName = products.OrderBy(p => p.ProductName);

            //foreach (var product01 in sortedProductsByName)
            //{
            //    Console.WriteLine(product01.ProductName);
            //}

            #endregion


            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWordsCaseInsensitive = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedWordsCaseInsensitive)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion


            #region 3. Sort a list of products by units in stock from highest to lowest.

            //var product = new List<Product>();

            //var sortedProductsByUnitsInStockDescending = product.OrderByDescending(p => p.UnitsInStock);

            //foreach (var product02 in sortedProductsByUnitsInStockDescending)
            //{
            //    Console.WriteLine($" {product02.ProductName} {product02.UnitPrice}");
            //}




            #endregion


            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var sortedDigits = Arr.OrderBy(digit => digit.Length).ThenBy(digit => digit);

            //foreach (var digit in sortedDigits)
            //{
            //    Console.WriteLine(digit);
            //}


            #endregion


            #region 5. Sort first by word length and then by a case-insensitive sort of the words in an array.


            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = words.OrderBy(word => word.Length).ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion


            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.


            //var producttt = new List<Product>();

            //var sortedProducts = products.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var productt in sortedProducts)
            //{
            //    Console.WriteLine($"{productt.Category} - {productt.ProductName}: {productt.UnitPrice}");
            //}

            #endregion


            #region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr.OrderBy(word => word.Length).ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion



            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var digitsWithSecondLetterI = Arr.Where(digit => digit.Length > 1 && digit[1] == 'i').Reverse();


            //foreach (var digit in digitsWithSecondLetterI)
            //{
            //    Console.WriteLine(digit);
            //}

            #endregion



        }
    }
}

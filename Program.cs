using System.Text;

namespace C50_GSat_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Qusetion 1
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion

            #region Qusetion2

            //string firstBook = "Clean Code";
            //string secondBook = "Clean Code";
            //bool isSameReference = object.ReferenceEquals(firstBook, secondBook);
            //Console.WriteLine(isSameReference);
            #endregion

            #region Question 3

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb.ToString());

            #endregion

            #region Question04
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb.ToString());
            #endregion


            #region Question05
            //string title = "Clean Code";
            //int pages = 464;
            //string sentence = "Book: " + title + ", Pages: " + pages;
            //Console.WriteLine(sentence);
            #endregion


            #region Question06
            //string sentence = $"Book: {title}, Pages: {pages}";
            //Console.WriteLine(sentence);
            #endregion


            #region Question07
            //string sentence = string.Format("Book: {0}, Pages: {1}", title, pages);
            //Console.WriteLine(sentence);
            #endregion


            #region Question08
            //int pages = 464;
            //if (pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}
            #endregion


            #region Question09
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            #endregion



            #region Question10
            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion



            #region Question11
            //int pages = 464;
            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);
            #endregion


            #region Question12
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //}
            #endregion









        }
    }
}

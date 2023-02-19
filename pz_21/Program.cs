using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCard bookCard = new BookCard(); 
            BookCard bookCard2 = new BookCard(111111, "Дмитрий Гласов", "Белоснежка", "2015", "Вышла");
            BookCard bookCard3 = new BookCard
            {
                Author = "Олег Ямаи",
                ID = 111112,
                Title = "путешествие щенка",
                Year = "2010",
                Condition = "Вышла"
            };
            BookCard bookCard4 = new BookCard
            {
               
            };
            bookCard.GetBookInfo();
            bookCard2.GetBookInfo();
            bookCard3.GetBookInfo();
            bookCard4.GetBookInfo();

            Console.ReadLine();

        }

    }
}

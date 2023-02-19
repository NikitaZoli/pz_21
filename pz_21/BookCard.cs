using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class BookCard
    {

        public int ID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Condition { get; set; }



        public BookCard(int id, string author, string title, string year, string condition)
        {
            ID = id;
            Author = author;
            Title = title;
            Year = year;
            Condition = condition;            
        }
        public BookCard()
        {
            ID = 0;
            Author = "неизвестный";
            Title = "пусто";
            Year = "неизвестно";
            Condition = "неизвестно";
        }
        public void GetBookInfo()
        {
            Console.WriteLine($"ID: {ID}\nАвтор: {Author}\nНазвание: {Title} \nГод: {Year} \nCостаяние книги: {Condition}");
        }
    }
}

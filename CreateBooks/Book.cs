using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateBooks
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Autor { get; set; }
        public virtual ICollection<Chapter> Chapters { get; set; }
        public Book()
        {
            Chapters = new List<Chapter>();
        }
        public override string ToString()
        {
            return Title;
        }
    }
}

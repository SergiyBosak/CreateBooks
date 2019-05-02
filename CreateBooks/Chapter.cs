using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateBooks
{
    public class Chapter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ChapterNumber { get; set; }
        public string Text { get; set; }

        public int? BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}

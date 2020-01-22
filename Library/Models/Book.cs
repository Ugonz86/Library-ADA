using System.Collections.Generic;

namespace Library.Models
{
    public class Book
    {
        public Book()
        {
            this.Authors = new HashSet<AuthorBook>();
        }

        public int BookId { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; } 
        public virtual Author Author { get; set; }
        public virtual ApplicationUser User { get; set; } 
        // public bool isChecked = false;

        public ICollection<AuthorBook> Authors { get;}
    }
}
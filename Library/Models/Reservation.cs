using System;
namespace Library.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public DateTime DateTime { get; set; }
        public int Quantity { get; set; }

    }
}
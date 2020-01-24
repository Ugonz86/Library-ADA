using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly LibraryContext _db;
        public ReservationsController(LibraryContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Reservation> model = _db.Reservations.Include(books => books.Author).ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.AuthorList = new SelectList(_db.Authors, "AuthorId", "Name");
            ViewBag.AuthorId = new SelectList(_db.Authors, "AuthorId", "Name");
            ViewBag.BookList = new SelectList(_db.Books, "BookId", "Description");
            ViewBag.BookId = new SelectList(_db.Books, "BookId", "Description");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Reservation newReservation)
        {
            _db.Reservations.Add(newReservation);
            _db.SaveChanges();
            return RedirectToAction("Index", new {id = newReservation.AuthorId});
        }

        public ActionResult Details(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Reservation thisReservation = _db.Reservations.FirstOrDefault(reservation => reservation.ReservationId == id);
            var authorBooks = _db.Books.Where(books => books.AuthorId == id).ToList();
            model.Add("reservation", thisReservation);
            return View(model);
        }

        public ActionResult DeleteAll()
        {
            var allReservations = _db.Reservations.ToList();
            return View();
        }

        [HttpPost, ActionName("DeleteAll")]
            public ActionResult DeleteAllConfirmed()
        {
            var allReservations = _db.Reservations.ToList();

        foreach (var reservation in allReservations)
        {
            _db.Reservations.Remove(reservation);
        }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DayThree.Models;
using Microsoft.AspNetCore.Mvc;

namespace DayThree.Controllers
{
    public class BooksController : Controller
    {
        // GET: BookCRUD
        // se koristi za da prikaze lista na knigi. Vo view - to ima kopce Create new sto nosi do 
        // action method Create od ovoj kontroler.       
        public ActionResult Index()
        {
           
            return View(DataModel.Books);
        }


        // Ovoj metod vraka view sto ima forma za da se dodade 
        // nova kniga (formata koristi Helper methods za da gi bindova propertijata od modelot Kniga)
        // pri klik na create na ovaa forma se dodava nova kniga vo listaa
        public ActionResult Create()
        {
            return View();
        }


        // ovoj metod moze da zabelezite deka ne vraka view tuku deka koristi RedirectToAction metod (metod koj ve prenasocuva kon drug action metod, 
        //vo slucajov ke ve prenasoci kon metod Index od ovoj kontroler).
        // Specificno e sto ovoj metod prima parametar od tipot Book. Ke vidite so breakpoint, posle popolnuvanje na formata i potvrdi, ovoj objekt e poln,
        // pa mozi da si zaklucite kako se praka podatoci od viewto kon kontrolerot.
        public ActionResult CreateWithModel(Book book)
        {
            DataModel.Books.Add(book);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            var book = DataModel.Books.FirstOrDefault(x => x.Id == id);
            return View(book);
        }

        public ActionResult Update(Book book)
        {
            var bookToBeUpdated = DataModel.Books.FirstOrDefault(x => x.Id == book.Id);
            bookToBeUpdated.Id = book.Id;
            bookToBeUpdated.IsOnSale = book.IsOnSale;
            bookToBeUpdated.Name = book.Name;
            bookToBeUpdated.Price = book.Price;
            bookToBeUpdated.Author = book.Author;

            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            var book = DataModel.Books.RemoveAll(x => x.Id == id);
            return RedirectToAction("Index");
        }
    }
}

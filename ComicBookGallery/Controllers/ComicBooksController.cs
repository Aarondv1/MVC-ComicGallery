using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
            {
                new Artist()  { Name="Dan Slott", Role="Script" },
                new Artist()  { Role = "Pencils", Name="Humberto Ramos" },
                new Artist()  { Name="Victor Olazaba", Role="Inks"},
                new Artist()  { Name= "Edgar Delgado", Role="Colors"},
                new Artist()  { Name="Chris Eliopoulous",Role="Letters"}
            }


            };


            //passing the comicbook instance into viewmethod call
            return View(comicBook);
            
            }
        }
    }

  


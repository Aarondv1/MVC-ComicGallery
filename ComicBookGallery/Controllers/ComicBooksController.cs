using ComicBookGallery.Data;
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
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        //Here is the 'Index Action method inbetween Class constructor and the Detail/Action method

            public ActionResult Index()
        {
            var comicbooks = _comicBookRepository.GetComicBooks();
            return View(comicbooks);
        }


        public ActionResult Detail(int? id)
        {

            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);

        
            
           }
        }
    }

  


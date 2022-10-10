using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class LivrosController : Controller
    {
        // GET: Livros
        // /livros/143978

        [Route("livros/{isbn?}")]
        public ActionResult Get(string isbn)
        {
            if (!string.IsNullOrEmpty(isbn))
            {
                return Content("livro específico: " + isbn);
            }
            return Content("Todos os livros");
            
        }
        //ex 1: /livros/idioma
        //ex 2: /livros/idioma/en
        //ex 3: /livros/idioma/de  (alemão)
        [Route("livros/idioma/{idioma=ptBR}")]
            public ActionResult GetByLanguahe(string idioma)
        {
            return Content($"Todos os livros no idioma: {idioma}");
        }
        //liros/autor/5
        [Route("livros/autor/{id:int}")]
        public ActionResult GetAuthorById(int id)
        {
            return Content($"Livros do autor com id = {id}");
        }

        //livros/autor/Tolkien
        [Route("livros/autor/{name}")]
        public ActionResult GetAuthorByName(string name)
        {
            return Content($"Livros do autor com name = {name}");

        }
    
       
    }

}
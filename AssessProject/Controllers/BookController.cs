using AssessProject.Entites;
using AssessProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssessProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServices BookServices;
        public BookController()
        {
            BookServices = new BookServices();
        }
        [HttpGet, Route("GetAllbooks")]
        public IActionResult GetAll()
        {
            try
            {
                List<Book> books = BookServices.GetBooks();
                return Ok(books);
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpGet, Route("GetbooksbyAuthor")]
        public IActionResult Get(string author)
        {
            try
            {
                List<Book> book = BookServices.GetBookByAuthor(author);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet, Route("GetBooksByyear")]
        public IActionResult Get(DateTime year)
        {
            try
            {
                List<Book> book = BookServices.GetBookByyear(year);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }

        }
        [HttpGet, Route("GetBooksByLanguage")]
        public IActionResult Getbook(string lang)
        {
            try
            {
                List<Book> books = BookServices.GetBookByLanguage(lang);
                return Ok(books);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost, Route("Books")]
        public IActionResult Add(Book book)
        {
            try
            {
                BookServices.AddBook(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }
        }
        [HttpPut, Route("Updatebook")]
        public IActionResult Edit(Book book)
        {

            try
            {
                BookServices.UpdateBook(book);
                return StatusCode(200, book);

            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }

        }
        [HttpDelete, Route("Deletebookbyid/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                BookServices.DeleteBook(id);
                return StatusCode(200, new JsonResult($"Book with Id {id} is Deleted"));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }


        }

    }
}

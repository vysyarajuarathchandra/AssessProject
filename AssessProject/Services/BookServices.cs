﻿using AssessProject.Database;
using AssessProject.Entites;
using Microsoft.EntityFrameworkCore;

namespace AssessProject.Services
{
    public class BookServices : IBookServices
    {
        private readonly Mycontext context;
        public BookServices()
        {
            context = new Mycontext();  
        }
        public void AddBook(Book book)
        {
            try
            {
                context.Books.Add(book);
                context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteBook(int BookId)
        {
            try
            {
                Book book = context.Books.SingleOrDefault(b => b.BookId == BookId);
                context.Books.Remove(book);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBookByAuthor(string BookAuthor)
        {
            try
            {
                List<Book> books = context.Books.Where(item => item.BookAuthor == BookAuthor).ToList();
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBookByLanguage(string BookLanguage)
        {
            try
            {
                List<Book>books = context.Books.Where(item => item.BookLanguage == BookLanguage).ToList();
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBookByyear(DateTime ReleaseDate)
        {
            try
            {
                List<Book> books = context.Books.Where(item => item.ReleaseDate == ReleaseDate).ToList();
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBooks()
        {
            try
            {
                return context.Books.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateBook(Book book)
        {
            try
            {
                context.Books.Update(book);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

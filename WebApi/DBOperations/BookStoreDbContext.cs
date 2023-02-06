﻿using Microsoft.EntityFrameworkCore;
using WebApi.Entitites;

namespace WebApi.DBOperations
{
    public class BookStoreDbContext : DbContext
	{

		public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
		{

		}
		public DbSet<Book> Books { get; set; }
		public DbSet<Genre> Genres { get; set; }
	}
}
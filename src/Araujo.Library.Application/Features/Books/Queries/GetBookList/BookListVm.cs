﻿using System;

namespace JvA.Library.Application.Features.Books.Queries.GetBookList
{
    public class BookListVm
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Publisher { get; set; }
        public Guid BookCategoryId { get; set; }
        public Guid LentToStudentId { get; set; }
    }
}

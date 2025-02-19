﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateOnly PublicationDate { get; set; }
        public string? AuthorName { get; set; }
        public int Views { get; set; }
    }
}

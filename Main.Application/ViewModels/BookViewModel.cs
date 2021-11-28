using Main.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.Application.ViewModels
{
    public class BookViewModel
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
    public class BookCreateViewModel
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }

}

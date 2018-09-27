using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySqlTestMvc.Models;

namespace MySqlTestMvc.Pages
{
    public class BlogsController : Controller
    {
        private readonly BloggingContext _context;

        public BlogsController(BloggingContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
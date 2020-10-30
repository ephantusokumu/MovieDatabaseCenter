using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieDatabaseCenter.Data;
using MovieDatabaseCenter.Models;

namespace MovieDatabaseCenter.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieDatabaseCenter.Data.MovieDatabaseCenterContext _context;

        public IndexModel(MovieDatabaseCenter.Data.MovieDatabaseCenterContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}

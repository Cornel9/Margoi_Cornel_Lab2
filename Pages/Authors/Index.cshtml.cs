using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Margoi_Cornel_Lab2.Data;
using Margoi_Cornel_Lab2.Models;

namespace Margoi_Cornel_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Margoi_Cornel_Lab2.Data.Margoi_Cornel_Lab2Context _context;

        public IndexModel(Margoi_Cornel_Lab2.Data.Margoi_Cornel_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}

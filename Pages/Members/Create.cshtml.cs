using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Uifalean_Emanuel_Lab2.Data;
using Uifalean_Emanuel_Lab2.Models;

namespace Uifalean_Emanuel_Lab2.Pages.Members
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly Uifalean_Emanuel_Lab2.Data.Uifalean_Emanuel_Lab2Context _context;

        public CreateModel(Uifalean_Emanuel_Lab2.Data.Uifalean_Emanuel_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Member Member { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Member.Add(Member);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

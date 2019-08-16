using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HR_Directory_MVC.Models;

namespace HR_Directory_MVC.Pages.Employee
{
    public class CreateModel : PageModel
    {
        private readonly HR_Directory_MVC.Models.HR_Directory_MVCContext _context;

        public CreateModel(HR_Directory_MVC.Models.HR_Directory_MVCContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HR_Directory_MVC.Models.Employee ployee { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employee.Add(ployee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
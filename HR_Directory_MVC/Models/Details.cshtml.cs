using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HR_Directory_MVC.Models
{
    public class DetailsModel : PageModel
    {
        private readonly HR_Directory_MVC.Models.HR_Directory_MVCContext _context;

        public DetailsModel(HR_Directory_MVC.Models.HR_Directory_MVCContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.SingleOrDefaultAsync(m => m.EmployeeID == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

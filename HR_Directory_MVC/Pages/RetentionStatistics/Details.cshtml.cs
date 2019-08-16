using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HR_Directory_MVC.Models;

namespace HR_Directory_MVC.Pages.RetentionStatistics
{
    public class DetailsModel : PageModel
    {
        private readonly HR_Directory_MVC.Models.HR_Directory_MVCContext _context;

        public DetailsModel(HR_Directory_MVC.Models.HR_Directory_MVCContext context)
        {
            _context = context;
        }

        public HR_Directory_MVC.Models.Employee ployee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ployee = await _context.Employee.SingleOrDefaultAsync(m => m.EmployeeID == id);

            if (ployee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

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
    public class IndexModel : PageModel
    {
        private readonly HR_Directory_MVC.Models.HR_Directory_MVCContext _context;

        public IndexModel(HR_Directory_MVC.Models.HR_Directory_MVCContext context)
        {
            _context = context;
        }

        public IList<HR_Directory_MVC.Models.Employee> ployee{ get;set; }

        public async Task OnGetAsync()
        {
            ployee = await _context.Employee.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Pages.Admin.Pages
{
    [Authorize(Roles = RoleNames.Admin)]
    public class AllPagesModel : PageModel
    {
#pragma warning disable IDE0052 // Remove unread private members
        private readonly IWebHostEnvironment _environment;
#pragma warning disable IDE0052 // Remove unread private members
        private readonly UserManager<IdentityUser> _userManager;
#pragma warning restore IDE0052 // Remove unread private members
        private readonly ApplicationDbContext _db;

        public List<PagesModel> PageList = new List<PagesModel>();
        public AllPagesModel(IWebHostEnvironment environment,
                                UserManager<IdentityUser> userManager,
                                ApplicationDbContext db)
        {
            _environment = environment;
            _userManager = userManager;
            _db = db;
        }

        public class InputModel
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string Price { get; set; }
            public string Visible { get; set; }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            PageList = await _db.PageModel.ToListAsync();

            return Page();
        }
    }
}

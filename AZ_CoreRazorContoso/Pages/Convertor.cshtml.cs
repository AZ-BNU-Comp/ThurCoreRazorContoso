using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AZ_CoreRazorContoso.Pages.Shared
{
    public class ConvertorModel : PageModel
    {
        public decimal Pounds { get; set; }
        public decimal Euros { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {

        }
    }
}
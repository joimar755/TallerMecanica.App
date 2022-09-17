using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TallerMecanica.App.Frontend.Pages.Personas
{
    public class Modal : PageModel
    {
        private readonly ILogger<Modal> _logger;

        public Modal(ILogger<Modal> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TallerMecanica.App.Frontend.Pages.Shared
{
    public class _modal : PageModel
    {
        private readonly ILogger<_modal> _logger;

        public _modal(ILogger<_modal> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Rms.Web.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration configuration;
        public MySettings settings;
        public IndexModel(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void OnGet()
        {
            settings =this.configuration.Get<MySettings>();
        }
    }

    public class MySettings
    {
        public string GatewayBaseUrl { get; set; }
        public string SiteText { get; set; }
    }
}

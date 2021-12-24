using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace Rms.Web.Pages.TableMenu
{
    public class IndexModel : PageModel
    {

        public IndexModel(HttpClient httpClient, IConfiguration configuration)
        {
            this._httpClient = httpClient;
            this._configuration = configuration;
        }

        private HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public void  OnGet()
        {
            ViewData["ResponseCode"] = "OnGet success full";
            ViewData["GatewayBaseUrl"] = this._configuration.GetValue<string>("GatewayBaseUrl");
        }

       
        public async Task<IActionResult> OnGetListMenu()
        {
            var response = await this._httpClient.GetAsync(this._configuration.GetValue<string>("GatewayBaseUrl") + "api/v1/w/weatherforecast/");

            var messge = await response.Content.ReadAsStringAsync();
            return new JsonResult(messge);
        }
    }
}

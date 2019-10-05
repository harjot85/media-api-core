using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPostsController : ControllerBase
    {
        public async Task<ActionResult<dynamic>> Get()
        {
            string url = "https://api.instagram.com/v1/users/self/media/recent/?access_token=" + Startup.ACCESS_TOKEN;
            using (HttpClient client = new HttpClient())
            {
                var xxxx=  await client.GetAsync(url);
                var resp = xxxx.Content;
                return xxxx;
            }
        }
    }
}
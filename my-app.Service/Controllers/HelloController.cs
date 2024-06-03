using Microsoft.AspNetCore.Mvc;

namespace my_app.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        static HttpClient client = new HttpClient();

        [HttpGet]
        [Route("hello")]
        public IActionResult GetHello()
        {
            return Ok("Hello, World!");
        }

        [HttpGet]
        [Route("test")]
        public IActionResult GetTest()
        {
            return Ok("Test success");
        }

        [HttpGet]
        [Route("externalcall")]
        public async Task<IActionResult> ExternalCall()
        {
            const string url = "https://dotnet-app-user6-user6-application.apps.cluster-5shjw.dynamic.redhatworkshops.io/Hello/hello4";

           try{
 HttpResponseMessage response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            return Ok(response.Content.ReadAsStringAsync());

           }
           catch(Exception ex)
           {
            return Ok(ex.Message);
           }
        }

        [HttpPost]
        [Route("externalpost")]
        public async Task<IActionResult> ExternalPost()
        {
            const string url = "https://dotnet-app-user6-user6-application.apps.cluster-5shjw.dynamic.redhatworkshops.io/Hello/hello4";

           try{
 HttpResponseMessage response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            return Ok(response.Content.ReadAsStringAsync());

           }
           catch(Exception ex)
           {
            return Ok(ex.Message);
           }
        }
    }
}

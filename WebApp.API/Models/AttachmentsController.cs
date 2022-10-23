using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.API.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentsController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAttachments()
        {
            string path = @"C:\Users\Wwwhu\source\repos\ExamBackend\EFCore\jsconfig1.json";
            if (!System.IO.File.Exists(path))
            {
                return NotFound();
            }
            var file = System.IO.File.ReadAllBytes(path);
            
            return File(file, "application/json" /* "text/plain" */, Path.GetFileName(path));
        }
    }
}

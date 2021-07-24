using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UploadFile.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UploadController : ControllerBase
    {
        [HttpPost]
        public IActionResult Recive(IFormFile file)
        {
            return Ok(new
            {
                file.Name,
                file.FileName,
                file.Length,
                file.ContentDisposition,
                file.ContentType
            });
        }
    }
}
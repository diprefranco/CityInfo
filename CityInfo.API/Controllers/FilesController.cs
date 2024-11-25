using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/files")]
    public class FilesController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;

        public FilesController(FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider;
        }

        [HttpGet("{fileId}")]
        public ActionResult GetFile(string fileId)
        {
            string path = "Azure-Quick-Start-for-NET-Developers.pdf";

            if (!System.IO.File.Exists(path))
            {
                return NotFound();
            }

            if (!_fileExtensionContentTypeProvider.TryGetContentType(path, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            var bytes = System.IO.File.ReadAllBytes(path);
            return File(bytes, contentType, Path.GetFileName(path));
        }
    }
}

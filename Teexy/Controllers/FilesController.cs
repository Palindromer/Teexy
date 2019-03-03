using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teexy.DAL;
using Teexy.Models;

namespace Teexy.Controllers
{
	[Route("api/[controller]")]
	public class FilesController : Controller
	{
		private FileRepository _fileRepository;

		public FilesController(FileRepository fileRepository)
		{
			_fileRepository = fileRepository;
		}

		[HttpGet("{id}")]
		public async Task<FileContentResult> Get(int id)
		{
			var file = await _fileRepository.Get(id);
			new FileExtensionContentTypeProvider().TryGetContentType(file.Name, out string contentType);

			return File(file.Body, contentType);
		}
	}
}

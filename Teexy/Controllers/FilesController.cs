using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Teexy.DAL;
using Teexy.Extensions;
using Teexy.Models;

namespace Teexy.Controllers
{
	[Route("api/[controller]")]
	public class FilesController : ControllerBase
	{
		private FileRepository _fileRepository;

		public FilesController(FileRepository fileRepository)
		{
			_fileRepository = fileRepository;
		}

		/// <summary>
		/// Get file by id.
		/// </summary>
		[HttpGet("{id}")]
		public async Task<FileContentResult> Get(int id)
		{
			var file = await _fileRepository.FindById(id);
			// new FileExtensionContentTypeProvider().TryGetContentType(file.Name, out string contentType);

			return File(file.Body, file.ContentType);
		}

		/// <summary>
		/// Upload file to the server.
		/// </summary>
		[HttpPost("[action]")]
		public async Task<int> Upload(IFormFile file)
		{
			var fileModel = file.ToModel();
			var id = await _fileRepository.Create(fileModel);
			return id;
		}
	}
}

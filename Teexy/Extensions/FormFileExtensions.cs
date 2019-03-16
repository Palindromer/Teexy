using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Teexy.Extensions
{
	public static class FormFileExtensions
	{
		public static Models.File ToModel(this IFormFile formFile)
		{
			var newFile = new Models.File
			{
				Name = formFile.FileName,
				ContentType = formFile.ContentType
			};

			if (formFile.Length > 0)
			{
				using (var ms = new MemoryStream())
				{
					formFile.CopyTo(ms);
					newFile.Body = ms.ToArray();
				}
			}

			return newFile;
		}
	}
}

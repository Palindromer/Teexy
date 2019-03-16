using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teexy.Builders
{
	public class UrlBuilder
	{
		public string CreateFileUrl(int fileId) => $"/api/files/{fileId}";
	}
}

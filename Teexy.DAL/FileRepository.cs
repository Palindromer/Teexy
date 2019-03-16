using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teexy.Models;

namespace Teexy.DAL
{
	public class FileRepository : EFGenericRepository<File>
	{
		public FileRepository(TeexyContext teexyContext) : base(teexyContext)
		{
		}
	}
}

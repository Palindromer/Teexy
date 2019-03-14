using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teexy.Models;

namespace Teexy.DAL
{
	public class FileRepository : BaseRepository
	{
		public FileRepository(TeexyContextFactory contextFactory) : base(contextFactory)
		{
		}

		public async Task<File> Get(int id)
		{
			var file = await DbContext.Files.FindAsync(id);
			return file;
		}

		public async Task Save(File file)
		{
			await DbContext.Files.AddAsync(file);
			await DbContext.SaveChangesAsync();
		}
	}
}

namespace Teexy.Models
{
	public class File : IEntity<int>
	{
		public int Id { get; set; }

		public byte[] Body { get; set; }

		public string Name { get; set; }

		public string ContentType { get; set; }
	}
}

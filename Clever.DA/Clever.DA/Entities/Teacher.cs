using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clever.DA.Entities
{
	public class Teacher
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		public string DOB { get; set; }
		public string ContactPhone { get; set; }
		[Required]
		public string ContactEmail { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clever.DA.Entities;

namespace Clever.DA
{
	public class Context:DbContext
	{
		public Context():base("CleverConn")
		{}
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Course> Courses { get; set; }
	}
}

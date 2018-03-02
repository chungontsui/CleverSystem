using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Clever.DA;
using Clever.DA.Entities;
using System.Reflection;

namespace Clever.Test
{
    public class DATest
    {
		private DataAccess _da = new DataAccess();

		[Test]
		public void CanAddNewTeacher()
		{
			var result = _da.AddTeacher(new Teacher() { FirstName = "Chung On", LastName = "Tsui", ContactEmail = "chung@teachers.com" });

			//MethodInfo method = Type.GetType(DataAccess).GetMethod("AddTeacher");
			Assert.That(result != null, "Couldn't Add New Teacher");
		}

		public void CanGetTeacher()
		{ }

		public void CanAddStudent()
		{

		}
    }
}

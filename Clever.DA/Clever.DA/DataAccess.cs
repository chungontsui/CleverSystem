using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clever.DA.Entities;

namespace Clever.DA
{
	public class DataAccess
	{
		public DataAccess()
		{

		}

		#region Teacher
		public IEnumerable<Teacher> GetTeachers()
		{
			using (var context = new Context())
			{
				return context.Teachers.ToList();
			}
		}

		public Teacher GetTeacherById(int id)
		{
			using (var context = new Context())
			{
				return context.Teachers.FirstOrDefault(t => t.Id == id);
			}
		}

		public Teacher AddTeacher(Teacher NewTeacher)
		{
			using (var context = new Context())
			{
				context.Teachers.Add(NewTeacher);
				context.SaveChanges();
			}

			return NewTeacher;
		}

		public Teacher UpdateTeacher(Teacher UpdateTeacher)
		{
			using (var context = new Context())
			{
				Teacher _updateTeacher = context.Teachers.FirstOrDefault(e => e.Id == UpdateTeacher.Id);
				if (_updateTeacher != null)
				{
					context.Entry(_updateTeacher).CurrentValues.SetValues(UpdateTeacher);
					context.SaveChanges();
				}
			}

			return UpdateTeacher;
		}

		public void DeleteTeacher(Teacher DeleteTeacher)
		{
			using (var context = new Context())
			{
				context.Teachers.Remove(DeleteTeacher);
				context.SaveChanges();
			}
		}
		#endregion

		#region Student
		public IEnumerable<Student> GetStudents()
		{
			using (var context = new Context())
			{
				return context.Students.ToList();
			}
		}

		public Student GetStudentById(int id)
		{
			using (var context = new Context())
			{
				return context.Students.FirstOrDefault(t => t.Id == id);
			}
		}

		public Student AddStudent(Student NewStudent)
		{
			using (var context = new Context())
			{
				context.Students.Add(NewStudent);
				context.SaveChanges();
			}

			return NewStudent;
		}

		public Student UpdateStudent(Student UpdateStudent)
		{
			using (var context = new Context())
			{
				Student _updateStudent = context.Students.FirstOrDefault(e => e.Id == UpdateStudent.Id);
				if (_updateStudent != null)
				{
					context.Entry(_updateStudent).CurrentValues.SetValues(UpdateStudent);
					context.SaveChanges();
				}
			}

			return UpdateStudent;
		}

		public void DeleteStudent(Student DeleteStudent)
		{
			using (var context = new Context())
			{
				context.Students.Remove(DeleteStudent);
				context.SaveChanges();
			}
		}
		#endregion

		#region Course
		public IEnumerable<Course> GetCourses()
		{
			using (var context = new Context())
			{
				return context.Courses.ToList();
			}
		}

		public Course GetCourseById(int id)
		{
			using (var context = new Context())
			{
				return context.Courses.FirstOrDefault(t => t.Id == id);
			}
		}

		public Course AddCourse(Course NewCourse)
		{
			using (var context = new Context())
			{
				context.Courses.Add(NewCourse);
				context.SaveChanges();
			}

			return NewCourse;
		}

		public Course UpdateCourse(Course UpdateCourse)
		{
			using (var context = new Context())
			{
				Course _updateCourse = context.Courses.FirstOrDefault(e => e.Id == UpdateCourse.Id);
				if (_updateCourse != null)
				{
					context.Entry(_updateCourse).CurrentValues.SetValues(UpdateCourse);
					context.SaveChanges();
				}
			}

			return UpdateCourse;
		}

		public void DeleteCourse(Course DeleteCourse)
		{
			using (var context = new Context())
			{
				context.Courses.Remove(DeleteCourse);
				context.SaveChanges();
			}
		}
		#endregion
	}
}

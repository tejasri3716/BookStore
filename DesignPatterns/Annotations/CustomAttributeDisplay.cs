namespace DesignPatterns.Annotations
{
	using System;

	public class CustomAttributeDisplay
	{
		public static void DisplayAttributes()
		{
			Student s = new Student();
			s.SetDetails(89, "Tejasri", 92.5);
			CustomAttribute.AttributeDisplay(typeof(Student));
			Console.WriteLine("");
			Console.WriteLine("Student Details");
			Console.WriteLine("Roll Number : " + s.GetRollNo());
			Console.WriteLine("Name : " + s.GetStudentName());
			Console.WriteLine("Marks : " + s.GetMarks());
		}
	}
}
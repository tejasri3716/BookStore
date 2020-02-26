namespace DesignPatterns.Annotations
{
    public class Student
    {
		// Private fields of class Student 
		private int rollNo;
		private string studentName;
		private double marks;

		// The attribute CustomAttribute is applied 
		// to methods of class Student 
		// Providing details of their utility 
		[CustomAttribute("Modifier", "Assigns the Student Details")]
		public void SetDetails(int r, string sn, double m)
		{
			rollNo = r;
			studentName = sn;
			marks = m;
		}

		[CustomAttribute("Accessor", "Returns Value of rollNo")]
		public int GetRollNo()
		{
			return rollNo;
		}

		[CustomAttribute("Accessor", "Returns Value of studentName")]
		public string GetStudentName()
		{
			return studentName;
		}

		[CustomAttribute("Accessor", "Returns Value of marks")]
		public double GetMarks()
		{
			return marks;
		}
	}
}
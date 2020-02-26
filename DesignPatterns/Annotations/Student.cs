//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Student.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.Annotations
{
    /// <summary>
    /// Student class used to write custom attributes
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The roll number
        /// </summary>
        private int rollNo;

        /// <summary>
        /// The student name
        /// </summary>
        private string studentName;

        /// <summary>
        /// The marks
        /// </summary>
        private double marks;

        /// <summary>
        /// Sets the details.
        /// </summary>
        /// <param name="rno">The r.</param>
        /// <param name="sname">The sn.</param>
        /// <param name="marks">The m.</param>
        [CustomAttribute("Modifier", "Assigns the Student Details")]
        public void SetDetails(int rno, string sname, double marks)
        {
            this.rollNo = rno;
            this.studentName = sname;
            this.marks = marks;
        }

        /// <summary>
        /// Gets the roll no.
        /// </summary>
        /// <returns>returns roll number</returns>
        [CustomAttribute("Accessor", "Returns Value of rollNo")]
        public int GetRollNo()
        {
            return this.rollNo;
        }

        /// <summary>
        /// Gets the name of the student.
        /// </summary>
        /// <returns>returns student name</returns>
        [CustomAttribute("Accessor", "Returns Value of studentName")]
        public string GetStudentName()
        {
            return this.studentName;
        }

        /// <summary>
        /// Gets the marks.
        /// </summary>
        /// <returns>return marks</returns>
        [CustomAttribute("Accessor", "Returns Value of marks")]
        public double GetMarks()
        {
            return this.marks;
        }
    }
}
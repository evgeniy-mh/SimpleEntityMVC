namespace MyUniversity.Models
{
    public enum Grade
    {
        A,B,C,D,E,F
    }

    public class Enrollment
    {
        /*The EnrollmentID property will be the primary key; 
         * this entity uses the classname ID pattern instead of ID by itself as you saw in the Student entity.
         */
        public int EnrollmentID { get; set; } 
        public int CourseID { get; set; }
        
        //The StudentID property is a foreign key, and the corresponding navigation property is Student.
        public int StudentID { get; set; }
        public Grade? Grade { get; set; } //? -> nullable

        //many to one -> property can only hold a single Student/Course entity
        public virtual Course Course { get; set; }
        public virtual Student Student {get; set;}
    }
}
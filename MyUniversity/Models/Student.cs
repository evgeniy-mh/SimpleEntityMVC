using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyUniversity.Models
{
    public class Student
    {
        /*
         * The ID property will become the primary key column of the database table that corresponds to this class. 
         * By default, the Entity Framework interprets a property that's named ID or classname ID as the primary key.
         */
        public int ID { get; set; }
        

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        /*
         * The Enrollments property is a navigation property. 
         * Navigation properties hold other entities that are related to this entity. 
         * In this case, the Enrollments property of a Student entity will hold all of the Enrollment entities that are related to that Student entity.
         * 
         * many-to-many or one-to-many -> must be a list
         */
        public virtual ICollection<Enrollment> Enrollments { get; set; }        
    }
}
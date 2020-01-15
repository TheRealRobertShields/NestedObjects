using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a single college course.
    /// </summary>
    public class Course
    {
        /// <summary>
        /// The name of the course.
        /// </summary>
        public string CourseTitle { get; set; }
        /// <summary>
        /// The unique identifier for the course.
        /// </summary>
        public int CourseId { get; set; }
        /// <summary>
        /// Brief summary of the course.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The number of college credits earned for a passing grade.
        /// </summary>
        public byte Credits { get; set; }
    }
}

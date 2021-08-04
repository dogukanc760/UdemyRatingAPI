using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Courses:IEntity
    {
        public int Id { get; set; }
        public int TrainerId { get; set; }
        public string CourseName { get; set; }
        public string CourseTarget { get; set; }
        public string TotalTime { get; set; }
        public decimal RatingPoint { get; set; }
        public string PersonelRating { get; set; }
    }
}

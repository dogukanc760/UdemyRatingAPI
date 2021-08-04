using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ratings:IEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int TrainerId { get; set; }
        public decimal RatingPoint { get; set; }
        public string RatingNote { get; set; }
    }
}

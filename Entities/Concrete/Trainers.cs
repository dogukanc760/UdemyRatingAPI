using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Trainers:IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string TrainerInfo { get; set; }
        public decimal StudentsSums { get; set; }
        public string PersonelRatings { get; set; }
    }
}

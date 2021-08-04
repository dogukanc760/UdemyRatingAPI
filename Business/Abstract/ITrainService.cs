using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITrainService
    {
        public IDataResult<List<Trainers>> GetAll();
        public IDataResult<Trainers> GetById(int id);
        public IResult Add(Trainers trainers);
        public IResult Delete(Trainers trainers);
        public IResult Update(Trainers trainers);
    }
}

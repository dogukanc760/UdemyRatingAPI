using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRatingService
    {
        public IDataResult<List<Ratings>> GetAll();
        public IDataResult<Ratings> GetRatingByCourseId(int id);
        public IDataResult<Ratings> GetRatingOneByTrainer(int trainerId, int courseId);
        public IDataResult<List<Ratings>> GetRatingAllByTrainer(int id);
        public IResult Add(Ratings rating);
        public IResult Update(Ratings rating);
        public IResult Delete(Ratings rating);

    }
}

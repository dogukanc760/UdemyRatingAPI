using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RatingManager : IRatingService
    {
        private IRatingDal _ratingDal;
        public RatingManager(IRatingDal ratingDal)
        {
            _ratingDal = ratingDal;
        }

        public IResult Add(Ratings rating)
        {
            _ratingDal.Add(rating);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Ratings rating)
        {
            _ratingDal.Delete(rating);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Ratings>> GetAll()
        {
            return new SuccessDataResult<List<Ratings>>(_ratingDal.GetAll().ToList());
        }

        public IDataResult<List<Ratings>> GetRatingAllByTrainer(int id)
        {
            return new SuccessDataResult<List<Ratings>>(_ratingDal.GetAll(r => r.TrainerId == id).ToList());
        }

        public IDataResult<Ratings> GetRatingByCourseId(int id)
        {
            return new SuccessDataResult<Ratings>(_ratingDal.Get(r => r.CourseId == id));
        }

        public IDataResult<Ratings> GetRatingOneByTrainer(int trainerId, int courseId)
        {
            return new SuccessDataResult<Ratings>(_ratingDal.Get(r => r.CourseId == courseId && r.TrainerId == trainerId));
        }

        public IResult Update(Ratings rating)
        {
            _ratingDal.Update(rating);
            return new SuccessResult(Messages.Updated);
        }
    }
}

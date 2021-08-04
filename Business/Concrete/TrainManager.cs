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
    public class TrainManager : ITrainService
    {
        private ITrainDal _trainerDal;
        public TrainManager(ITrainDal trainDal)
        {
            _trainerDal = trainDal;
        }
        public IResult Add(Trainers trainers)
        {
            _trainerDal.Add(trainers);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Trainers trainers)
        {
            _trainerDal.Delete(trainers);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Trainers>> GetAll()
        {
            return new SuccessDataResult<List<Trainers>>(_trainerDal.GetAll().ToList());
        }

        public IDataResult<Trainers> GetById(int id)
        {
            return new SuccessDataResult<Trainers>(_trainerDal.Get(t => t.Id == id));
        }

        public IResult Update(Trainers trainers)
        {
            _trainerDal.Update(trainers);
            return new SuccessResult(Messages.Updated);
        }
    }
}

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
    public class CourseManager : ICourseService
    {

        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IResult Add(Courses courses)
        {
            _courseDal.Add(courses);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Courses courses)
        {
            _courseDal.Delete(courses);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Courses> GetById(int id)
        {
            return new SuccessDataResult<Courses>(_courseDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Courses>> GetByTrainer(int id)
        {
            return new SuccessDataResult<List<Courses>>(_courseDal.GetAll(t=>t.TrainerId == id).ToList());
        }

        public IDataResult<List<Courses>> GetList()
        {
            return new SuccessDataResult<List<Courses>>(_courseDal.GetAll().ToList());
        }

        public IResult Update(Courses courses)
        {
            _courseDal.Update(courses);
            return new SuccessResult(Messages.Updated);
        }
    }
}

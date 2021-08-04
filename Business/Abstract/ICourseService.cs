using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        IDataResult<List<Courses>> GetList();
        IDataResult<Courses> GetById(int id);
        IDataResult<List<Courses>> GetByTrainer(int id);
        IResult Add(Courses courses);
        IResult Delete(Courses courses);
        IResult Update(Courses courses);
    }
}

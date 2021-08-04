using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinnessModule:Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            

            builder.RegisterType<CourseManager>().As<ICourseService>();
            builder.RegisterType<EfCourseDal>().As<ICourseDal>();
             
            builder.RegisterType<RatingManager>().As<IRatingService>();
            builder.RegisterType<EfRatingDal>().As<IRatingDal>();

            builder.RegisterType<TrainManager>().As<ITrainService>();
            builder.RegisterType<EfTrainDal>().As<ITrainDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            
        }


    }
}

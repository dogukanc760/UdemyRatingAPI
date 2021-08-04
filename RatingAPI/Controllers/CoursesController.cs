using Business.Abstract;

using Entities.Concrete;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private ICourseService _courseService;
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = _courseService.GetList();
            if (result.Data!=null)
            {
                return Ok(result.Data);
            }
            return BadRequest("Data has not found!");
        }

        [HttpGet("getbyid")]
        public ActionResult GetById(int id)
        {
            var result = _courseService.GetById(id);
            if (result.Data!=null)
            {
                return Ok(result.Data);
            }
            return BadRequest("Data has not found!");
        }

        [HttpGet("getbytrainer")]
        public ActionResult GetByTrainer(int id)
        {
            var result = _courseService.GetByTrainer(id);
            if (result.Data!=null)
            {
                return Ok(result.Data);
            }
            return BadRequest("Data has not found!");
        }

        [HttpGet("add")]
        public ActionResult Add(Courses courses)
        {
            var result = _courseService.Add(courses);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("update")]
        public ActionResult Update(Courses courses)
        {
            var result = _courseService.Update(courses);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("delete")]
        public ActionResult Delete(Courses courses)
        {
            var result = _courseService.Delete(courses);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

    }
}

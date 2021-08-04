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
    public class RatingController : ControllerBase
    {
        private IRatingService _ratingService;
        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = _ratingService.GetAll();
            
            if (result.Data!=null)
            {
                return Ok(result.Data);
            }
            return BadRequest("Data has not found!");
        }

        [HttpGet("allratingbytrainer")]
        public ActionResult AllRatingByTrainer(int id)
        {
            var result = _ratingService.GetRatingAllByTrainer(id);
            if (result.Data!=null)
            {
                return Ok(result.Data);
            }
            return BadRequest("Data has not found!");
        }

        [HttpGet("getratingbycourse")]
        public ActionResult RatingByCourse(int id)
        {
            var result = _ratingService.GetRatingByCourseId(id);
            if (result.Data!=null)
            {
                return Ok(result.Data);
            }
            return BadRequest("Data has not found!");
        }

        [HttpGet("getratingonebyone")]
        public ActionResult RatingOneCourseByTrainer(int courseId, int trainerId)
        {
            var result = _ratingService.GetRatingOneByTrainer(trainerId, courseId);
            if (result.Data!=null)
            {
                return Ok(result.Data);
            }
            return BadRequest("Data has not found!");
        }

        [HttpPost("add")]
        public ActionResult Add(Ratings rating)
        {
            var result = _ratingService.Add(rating);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public ActionResult Delete(Ratings ratings)
        {
            var result = _ratingService.Delete(ratings);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public ActionResult Update(Ratings ratings)
        {
            var result = _ratingService.Update(ratings);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}

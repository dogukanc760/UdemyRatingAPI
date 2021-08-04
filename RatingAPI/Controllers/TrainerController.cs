using Business.Abstract;

using Entities.Concrete;

using Microsoft.AspNetCore.Authorization;
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
    public class TrainerController : ControllerBase
    {
        private ITrainService _trainService;
        public TrainerController(ITrainService trainService)
        {
            _trainService = trainService;
        }

        [HttpGet("getall")]
        //[Authorize(Roles="Trainers.List")]
        public ActionResult GetAll()
        {
            var result = _trainService.GetAll();
            
            if (result.Data!=null)
            {
                return Ok(result.Data);
            }
            return BadRequest("Data has not found!");
        }

        [HttpGet("getbyid")]
        public ActionResult GetById(int id)
        {
            var result = _trainService.GetById(id);
            if (result.Data!=null)
            {
                return Ok(result.Data);
            }
            return BadRequest("Data has not found!");
        }

        [HttpPost("add")]
        public ActionResult Add(Trainers trainer)
        {
            var result = _trainService.Add(trainer);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public ActionResult Update(Trainers trainer)
        {
            var result = _trainService.Update(trainer);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public ActionResult Delete(Trainers trainer)
        {
            var result = _trainService.Delete(trainer);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}

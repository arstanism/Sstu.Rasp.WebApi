using Microsoft.AspNetCore.Mvc;
using Sstu.Rasp.BLL.Contracts;
using System;

namespace Sstu.Rasp.WebApi.Controllers
{
    public class ScheduleController : BaseApiController
    {
        private readonly IScheduleLogic _logic;

        public ScheduleController(IScheduleLogic logic)
        {
            _logic = logic;
        }


        [Route("[action]/{id}")]
        [HttpGet]
        public IActionResult GetByGroupId(int id)
        {
            try
            {
                var result = _logic.GetByGroupId(id);

                if (result == null)
                {
                    return NotFound();
                }

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public IActionResult GetByTeacherId(int id)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public IActionResult GetByRoomId(int id)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
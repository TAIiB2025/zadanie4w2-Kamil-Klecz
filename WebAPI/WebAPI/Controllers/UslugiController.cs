using BLL;
using BLL.Model;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("")]
    [ApiController]
    public class UslugiController : ControllerBase
    {
        private readonly IUslugiService _osobyService;

        public UslugiController(IUslugiService osobyService)
        {
            _osobyService = osobyService;
        }

        [HttpGet]
        public IEnumerable<UslugaEntity> Get()
        {
            return _osobyService.Get();
        }
        [HttpGet("id")]
        public UslugaBody GetByID(int id)
        {
            return _osobyService.GetById(id);
        }
        [HttpPost]
        public void Post([FromBody] UslugaBody osobaPostDTO)
        {
            _osobyService.post(osobaPostDTO);
        }
        [HttpPut("id")]
        public void Put(int id, [FromBody] UslugaBody osobaPostDTO)
        {
            _osobyService.Put(id, osobaPostDTO);
        }

        //[HttpPost]
        //public IActionResult Post([FromBody] UslugaBody osobaPostDTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _osobyService.post(osobaPostDTO);
        //    return NoContent();
        //}

        //[HttpPut("id")]
        //public IActionResult Put(int id, [FromBody] UslugaBody osobaPostDTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _osobyService.Put(id, osobaPostDTO);
        //    return NoContent();
        //}



        [HttpDelete("id")]
        public void Delete(int id)
        {
            _osobyService.Delete(id);
        }


        [HttpGet("filtr")]
        public IEnumerable<UslugaBody> GetFiltered([FromQuery] string? nazwa = null)
        {
            return _osobyService.GetFiltered(nazwa);
        }

    }
}

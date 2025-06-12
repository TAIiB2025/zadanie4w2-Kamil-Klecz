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

        [HttpDelete("id")]
        public void Delete(int id)
        {
            _osobyService.Delete(id);
        }
    }
}

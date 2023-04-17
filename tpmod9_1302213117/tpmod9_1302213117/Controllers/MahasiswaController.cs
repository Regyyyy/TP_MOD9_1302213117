using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tpmod9_1302213117.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        static List<Mahasiswa> dataUsers = new List<Mahasiswa>
        {
            new Mahasiswa("Alif Taufiqurrahman","1302213011"),
            new Mahasiswa("Deva Angela Felisitas Toding","1302213011"),
            new Mahasiswa("Iqro Banyuanto","1302213061"),
            new Mahasiswa("Rahma Sakti Rahardian","1302210095"),
            new Mahasiswa("Regy Renanda Rahman","1302213117")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataUsers;
        }

        [HttpGet("(id")]
        public Mahasiswa Get(int id)
        {
            return dataUsers[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa newMhs)
        {
            dataUsers.Add(newMhs);
        }

        [HttpPut("(id)")]
        public void Put(int id, [FromBody]Mahasiswa updatedMhs)
        {
            dataUsers[id] = updatedMhs;
        }

        [HttpDelete("(id)")]
        public void Delete(int id)
        {
            dataUsers.RemoveAt(id);
        }
    }
}

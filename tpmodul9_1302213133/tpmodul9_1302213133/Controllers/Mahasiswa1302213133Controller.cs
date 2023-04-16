    using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul9_1302213133.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa1302213133Controller : ControllerBase
    {
        private static List<Mahasiswa1302213133> mhs = new List<Mahasiswa1302213133>
        {
            new Mahasiswa1302213133("Faris Siddiq Ramdan Putra", "1302213133"),
            new Mahasiswa1302213133("Muhammad Fadhil Ardiansyah Supiyan", "1302210006"),
            new Mahasiswa1302213133("Muhammad Vikhan Muharram", "1302213089"),
            new Mahasiswa1302213133("Heru Ikhsan Maulana", "1302210009"),
            new Mahasiswa1302213133("Bimo Zachriansyah Wicaksono Hermawan", "1302213012")
        };
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Mahasiswa1302213133> Get()
        {
            return mhs;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Mahasiswa1302213133 Get(int id)
        {
            return mhs[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa1302213133 value)
        {
            mhs.Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa1302213133 value)
        {
            //mhs[id] = value;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mhs.RemoveAt(id);
        }
    }
}

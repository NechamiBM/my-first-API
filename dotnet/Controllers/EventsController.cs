using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        List<Event> EventList = new List<Event> { new Event(DateTime.Now), new Event(DateTime.Now) };

        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Event> Get() => EventList;

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] string value) => EventList.Add(new Event { Title = value });


        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) => EventList.Find(c => c.Id == id).Title = value;


        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) => EventList.Remove(EventList.Find(c => c.Id == id));
        
    }
}

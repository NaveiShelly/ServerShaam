using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private static readonly List<TaskModel> Tasks = new();
        private static int _nextId = 1;

        [HttpGet]
        public ActionResult<IEnumerable<TaskModel>> GetAll()
        {
            return Ok(Tasks);
        }

        [HttpGet("{id}")]
        public ActionResult<TaskModel> Get(int id)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == id);
            return task is null ? NotFound() : Ok(task);
        }

        [HttpPost]
        public ActionResult<TaskModel> Add([FromBody] TaskModel task)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            task.Id = _nextId++;
            Tasks.Add(task);

            return CreatedAtAction(nameof(Get), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] TaskModel updatedTask)
        {
            var existing = Tasks.FirstOrDefault(t => t.Id == id);
            if (existing is null) return NotFound();

            existing.Title = updatedTask.Title;
            existing.Description = updatedTask.Description;
            existing.Priority = updatedTask.Priority;
            existing.DueDate = updatedTask.DueDate;
            existing.Status = updatedTask.Status;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == id);
            if (task is null) return NotFound();

            Tasks.Remove(task);
            return NoContent();
        }
    }
}

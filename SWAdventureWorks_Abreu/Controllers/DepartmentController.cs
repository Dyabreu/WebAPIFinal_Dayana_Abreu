using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWAdventureWorks_Abreu.Models;

namespace SWAdventureWorks_Abreu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
       
        private readonly AdventureWorks2019Context context;

        public DepartmentController(AdventureWorks2019Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Department>> Get()
        {
            return context.Departments.ToList();
        }


        [HttpGet("{id}")]
        public ActionResult <Department> GetbyId (short id)
        {
            Department department = (from d in context.Departments
                                     where d.DepartmentId== id
                                     select d).SingleOrDefault();
            return department;
        }

        [HttpGet("name/{name}")]
        public ActionResult <IEnumerable <Department>> GetbyName (string name)
        {
            List<Department> departments = (from d in context.Departments
                                            where d.Name==name
                                            select d).ToList ();
            return departments;
        }



        [HttpPost]

        public ActionResult Post(Department department)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Departments.Add(department);
            context.SaveChanges();
            return Ok();

        }

        [HttpPut("{id}")]

        public ActionResult Put(short id, [FromBody] Department department)
        {
            if (id != department.DepartmentId)
            {
                return BadRequest();
            }
            context.Entry(department).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Department> Delete(short id)
        {
            var department = (from p in context.Departments
                             where p.DepartmentId == id
                             select p).SingleOrDefault();
            if (department == null)
            {
                return NotFound();
            }
            context.Departments.Remove(department);
            context.SaveChanges();
            return department;
        }

    }
}

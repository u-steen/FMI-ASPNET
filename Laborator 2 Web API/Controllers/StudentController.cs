using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab2_24.Models;

namespace Lab2_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ana", Age = 21},
            new Student { Id = 1, Name = "Maria", Age = 19},
            new Student { Id = 1, Name = "Vlad", Age = 22},
            new Student { Id = 1, Name = "Florin", Age = 25},
            new Student { Id = 1, Name = "Marian", Age = 20},
        };

        // endpoint
        // Get
        // [HttpGet]
        // public List<Student> Get()
        // {
        //     return students.OrderBy(o => o.Age).ToList();
        // }

        [HttpGet(Name = "getAllOrdered")]
        public List<Student> GetAllOrdered()
        {
            return students.OrderBy(o => o.Name).ToList();
        }

        // Create

        [HttpPost]
        public List<Student> Add(Student student)
        {
            students.Add(student);
            return students;
        }

        // [HttpDelete]
        // public List<Student> Delete(Student student)
        // {
        //     var studentIndex = students.FindIndex( x => x.Id == student.Id);
        //     students.RemoveAt(studentIndex);
        //     return students;
        // }
        //
        [HttpDelete(Name = "deleteByIndex")]
        public List<Student> Delete(int index)
        {
            students.RemoveAt(index);
            return students;

        }
    }
}

using EFCExample.DataContext;
using EFCExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCExample.Services
{
    public class ServiceCourse
    {
        private readonly AppDbContext _context;

        public ServiceCourse() => _context = App.GetContext();

        public bool Create(Course entity)
        {
            bool created;

            try
            {
                _context.Courses.Add(entity);
                _context.SaveChanges();
                created = true;
            }
            catch (Exception)
            {
                throw;
            }

            return created;
        }

        public bool DeleteAll()
        {
            bool created;

            try
            {
                _context.Courses.RemoveRange(_context.Courses.ToList());
                _context.SaveChanges();
                created = true;
            }
            catch (Exception)
            {
                throw;
            }

            return created;
        }

        public List<Course> Get()
        {
            List<Course> courses = null;
            try
            {
                courses = _context.Courses.ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return courses;
        }

        public Course GetById(int Id)
        {
            Course Course = null;
            try
            {
                Course = _context.Courses.Where(x => x.CourseID == Id).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            return Course;
        }


    }
}

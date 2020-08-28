using EFCExample.DataContext;
using EFCExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCExample.Services
{
    public class ServicePerson
    {
        private readonly AppDbContext _context;

        public ServicePerson() => _context = App.GetContext();

        public bool Create(Person entity)
        {
            bool created;

            try
            {                   
                _context.People.Add(entity);
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
                _context.People.RemoveRange(_context.People.ToList());
                _context.SaveChanges();
                created = true;
            }
            catch (Exception)
            {
                throw;
            }

            return created;
        }

        public List<Person> Get()
        {
            List<Person> people = null;
            try
            {
                people = _context.People.ToList();                               
            }
            catch (Exception)
            {
                throw;
            }

            return people;
        }

        public Person GetById(int Id)
        {
            Person person = null;
            try
            {
                person = _context.People.Where(x => x.PersonID == Id).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            return person;
        }


    }
}

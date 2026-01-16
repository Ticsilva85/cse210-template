using System;
using System.Collections.Generic;
using System.Net;


namespace Resumes.Models
{
    public class Resume
    {
        public string _name;

        public List<Job> _jobs = new List<Job>();

        public void Display()
        {
            System.Console.WriteLine($"{_name}.");
            System.Console.WriteLine("Jobs: ");

            foreach (Job job in _jobs)
            {
                job.Present();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Wincubate.CS7.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IList<Employee> _employees;

        public EmployeeRepository()
        {
            Employee bo = new SoftwareArchitect
            {
                FirstName = "Bo",
                LastName = "Rammstein",
                Level = SoftwareArchitectLevel.Senior,
                VisioDrawingsProduced = 87
            };
            Employee henrik = new SoftwareEngineer
            {
                FirstName = "Henrik",
                LastName = "Lethbane",
                Level = SoftwareEngineerLevel.Senior,
                CodeLinesProduced = 251723
            };
            Employee jeppe = new SoftwareEngineer
            {
                FirstName = "Jeppe",
                LastName = "Finlandia",
                Level = SoftwareEngineerLevel.Senior,
                CodeLinesProduced = 235919
            };
            Employee rasmus = new SoftwareArchitect
            {
                FirstName = "Rasmus",
                LastName = "Motorhead",
                Level = SoftwareArchitectLevel.Senior,
                VisioDrawingsProduced = 42
            };
            Employee nina = new BusinessAnalyst
            {
                FirstName = "Nina",
                LastName = "Hololens"
            };
            Employee nils = new ProjectManager
            {
                FirstName = "Nils",
                LastName = "Gram Kilo",
                Level = ProjectManagerLevel.Senior,
                Team = "Banzai Raccoons"
            };
            Employee peter = new StudentProgrammer
            {
                FirstName = "Peter",
                LastName = "Thailand",
                MentoredBy = jeppe
            };
            Employee jesper = new SoftwareEngineer
            {
                FirstName = "Jesper",
                LastName = "Gulmann Henriksen",
                Level = SoftwareEngineerLevel.Lead,
                CodeLinesProduced = 176
            };

            _employees = new List<Employee>
            {
                bo, henrik, jeppe, rasmus, nina, nils, peter, jesper
            };
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees.ToList();
        }

        //public void Add( Employee employee )
        //{
        //    if (employee == null)
        //    {
        //        throw new ArgumentNullException("employee");
        //    }

        //    _employees.Add(employee);
        //}

        public void Add( Employee employee ) =>
            _employees.Add(employee ?? throw new ArgumentNullException(nameof(employee)));
    }
}

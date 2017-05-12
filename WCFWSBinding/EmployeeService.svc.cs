using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFWSBinding
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        public string GetNameById(int id)
        {
            return id > 0 ? "John Johnny" : string.Empty;
        }

        public Employee GetEmployeeById(int id)
        {
            if (id > 0)
            {
                var emp = new Employee()
                {
                    EmployeeId = 2,
                    Address = "Sterling VA",
                    CompanyName = "Antra",
                    JoiningDate = "12/12/2016",
                    Name = "John Johnny"
                };
                return emp;
            }
            return new Employee();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfMessageContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        public EmployeeInfoResponseMessage GetEmployeeById(EmployeeInfoRequestMessage employeeInfoRequest)
        {
            EmployeeInfoResponseMessage response = new EmployeeInfoResponseMessage();
            if (employeeInfoRequest.AuthenticationCode != "12345")
            {
                //return fault response    
            }
            else
            {
                Employee emp = new Employee()
                {
                    EmployeeId = 2,
                    Address = "Sterling VA",
                    CompanyName = "Antra",
                    JoiningDate = "12/12/2016",
                    Name = "John Johnny"
                };


                response.EmployeeInfo = emp;
            }

            return response;
        }
    }
}
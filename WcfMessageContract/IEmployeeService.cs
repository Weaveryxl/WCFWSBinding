using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfMessageContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        EmployeeInfoResponseMessage GetEmployeeById(EmployeeInfoRequestMessage stdInfoMessage);
    }

    [MessageContract(IsWrapped = false)]
    public class EmployeeInfoRequestMessage
    {
        [MessageHeader()]
        public string AuthenticationCode { get; set; }

        [MessageBodyMember()]
        public int EmployeeId { get; set; }

    }

    [MessageContract(IsWrapped = false)]
    public class EmployeeInfoResponseMessage
    {
        [MessageBodyMember()]
        public Employee EmployeeInfo { get; set; }
    }

    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmployeeId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string JoiningDate { get; set; }

        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public string Address { get; set; }
    }
}
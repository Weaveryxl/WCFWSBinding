using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFClient.EmpRef;

namespace WCFClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpRef.EmployeeServiceClient client = new EmployeeServiceClient();
            var emp =  client.GetEmployeeById(1);


            EmpRefMessage.EmployeeServiceClient client2= new EmpRefMessage.EmployeeServiceClient();

            var emp2 = client2.GetEmployeeById("12345", 1);

            Response.Write(emp2.Name);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAPIinWebForms.Models;
using System.Net.Http;

namespace WebAPIinWebForms
{
    public partial class BindDDL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:62749/api/");

            var ConsumeAPI = client.GetAsync("myemployees");
            ConsumeAPI.Wait();

            var readdata= ConsumeAPI.Result;
            if(readdata.IsSuccessStatusCode)
            {
                var displayresult=readdata.Content.ReadAsAsync<IList<Employee>>();

                IEnumerable<Employee> employees = null;
                displayresult.Wait();

                employees=displayresult.Result;
                DropDownList1.DataSource = employees;
                DropDownList1.DataTextField = "Empname";
                DropDownList1.DataBind();
            }

        }
    }
}
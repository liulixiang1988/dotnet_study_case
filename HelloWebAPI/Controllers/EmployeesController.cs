using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using HelloWebAPI.Models;

namespace HelloWebAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        public static IList<Employee> list = new List<Employee>()
        {
            new Employee(){ ID=1, FirstName = "刘", LastName = "理想", Department = 1},
            new Employee() {ID = 2, FirstName = "龙", LastName = "珑", Department = 2}
        };

        //public IEnumerable<Employee> Get()
        //{
        //    return list;
        //}

        //public Employee Get(int id)
        //{
        //    return list.First(e => e.ID == id);
        //}

        //public void Post(Employee employee)
        //{
        //    int maxId = list.Max(e => e.ID);
        //    employee.ID = maxId + 1;
        //    list.Add(employee);
        //}

        //public void Put(int id, Employee employee)
        //{
        //    int index = list.ToList().FindIndex(e => e.ID == id);
        //    list[index] = employee;
        //}

        //public void Delete(int id)
        //{
        //    Employee employee = Get(id);
        //    list.Remove(employee);
        //}

        //[AcceptVerbs("Get")]
        //[HttpGet]
        //public Employee RetrieveEmployeeById(int id)
        //{
        //    return list.First(e => e.ID == id);
        //}

//        [HttpGet]
//        public IEnumerable<Employee> RpcStyleGet()
//        {
//            return list;
//        }
//
//        public Employee GetEmployeeRpcStyle(int id)
//        {
//            return list.First(e => e.ID == id);
//        }
        //public Employee Get(int orgid, int id)
        //{
        //    return list.First(e => e.ID == id);
        //}
        //public Employee Get(int id)
        //{
        //    var employee = list.FirstOrDefault(e => e.ID == id);
        //    if (employee == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }
        //    return employee;
        //}

        //public IEnumerable<Employee> GetByDepartment(int department)
        //{
        //    int[] validDepartments = {1, 2, 3, 5, 8, 13};

        //    if (!validDepartments.Any(d => d==department))
        //    {
        //        var responese = new HttpResponseMessage()
        //        {
        //            StatusCode = (HttpStatusCode) 422,
        //            ReasonPhrase = "Invalid Department"
        //        };
        //        throw new HttpResponseException(responese);
        //    }

        //    return list.Where(e => e.Department == department);
        //}

        public IEnumerable<Employee> Get([FromUri] Filter filter)
        {
            return list.Where(e => e.Department == filter.Department && e.LastName == filter.LastName);
        }

        public HttpResponseMessage Post(Employee employee)
        {
            int maxId = list.Max(e => e.ID);
            employee.ID = maxId + 1;

            list.Add(employee);

            var response = Request.CreateResponse<Employee>(HttpStatusCode.Created, employee);

            string uri = Url.Link("DefaultApi", new {id = employee.ID});
            response.Headers.Location = new Uri(uri);
            return response;
        }
    }
}

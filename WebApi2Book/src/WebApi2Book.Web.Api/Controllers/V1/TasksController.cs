﻿using System.Net.Http;
using System.Web.Http;
using WebApi2Book.Web.Api.Models;
using WebApi2Book.Web.Common.Routing;

namespace WebApi2Book.Web.Api.Controllers.V1
{
    [ApiVersion1RoutePrefix("tasks")]
    public class TasksController : ApiController
    {
        [Route("", Name="AddTaskRoute")]
        [HttpPost]
        public Task AddTask(HttpRequestMessage reuestMessage, Task newTask)
        {
            return new Task
            {
                Subject = "V1版本，newTask.Subject" + newTask.Subject
            };
        }
    }
}

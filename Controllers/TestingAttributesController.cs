using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [Route("api/TodoItems")]
    [ApiController]
    public class TestingAttributesController : ControllerBase
    {
        [Required(ErrorMessage ="´Hej fra Car")]
        public object TestObj;
    }
}
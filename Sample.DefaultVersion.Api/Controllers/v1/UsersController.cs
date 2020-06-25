using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample.DefaultVersion.Api.Models;

namespace Sample.DefaultVersion.Api.Controllers.v1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("v{version:apiVersion}/[controller]")]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        static IEnumerable<UserModel> users = new[]
        {
            new UserModel(){Id=Guid.NewGuid(), Username="john_smith", FullName="John Smith" },
            new UserModel(){Id=Guid.NewGuid(), Username="payton_keenan", FullName="Payton Keenan" }
        };

        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            return users;
        }
    }
}

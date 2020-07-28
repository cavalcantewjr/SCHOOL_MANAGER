using Domain.Business;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISchool_Business _school_Business;
        private readonly ILogger _logger;

        public SchoolController(ISchool_Business school_Business, ILogger logger)
        {
            _school_Business = school_Business;
            _logger = logger;
        }

        [Route("AddEscola")]
        [HttpPost]
        public IActionResult AddSchool([FromBody] School school)
        {
            try
            {
                _school_Business.InsertSchool(school);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro no cadastro {ex.Message}");
            }
            
        }

        [HttpGet("ListAll")]
        public List<School> ListAll()
        {
            try
            {
                return _school_Business.ListSchools();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao retornar liga {ex.Message}");
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Mime;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MarioMendonca.SpeechPlanning.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OradorController : ControllerBase
    {
        private readonly ILogger<OradorController> _logger;
        private readonly IApplicationServiceOrador _applicationServiceOrador;

        public OradorController(IApplicationServiceOrador applicationServiceOrador,
            ILogger<OradorController> logger)
        {
            _logger = logger;
            _applicationServiceOrador = applicationServiceOrador;
        }

        [HttpGet]
        [Route("/orador/", Name = "OradorGetAll")]
        [ProducesResponseType(typeof(OradorDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<OradorDTO>> GetAll()
        {
            return Ok(_applicationServiceOrador.GetAll());
        }

        [HttpGet]
        [Route("/orador/{id}", Name = "OradorGetById")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(OradorDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<string> GetById(Guid id)
        {
            return Ok(_applicationServiceOrador.GetById(id));
        }

        [HttpGet]
        [Route("/orador/search/{nome}", Name = "OradorGetByNome")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(OradorDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<OradorDTO>> GetByNome(string nome)
        {
            return Ok(_applicationServiceOrador.GetByNome(nome));
        }

        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(OradorDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] OradorDTO oradorDto)
        {
            try
            {
                if (oradorDto == null)
                    return NotFound();

                _applicationServiceOrador.Add(oradorDto);
                return Ok("Orador cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(OradorDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Put([FromBody] OradorDTO oradorDto)
        {
            try
            {
                if (oradorDto == null)
                    return NotFound();

                _applicationServiceOrador.Update(oradorDto);
                
                return Ok("Orador atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete()]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(OradorDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Delete([FromBody] OradorDTO oradorDto)
        {
            try
            {
                if (oradorDto == null)
                    return NotFound();

                _applicationServiceOrador.Remove(oradorDto);
                
                return Ok("Orador removido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
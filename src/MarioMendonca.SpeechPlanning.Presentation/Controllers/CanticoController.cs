using System;
using System.Collections.Generic;
using System.Net.Mime;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MarioMendonca.SpeechPlanning.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CanticoController : ControllerBase
    {
        private readonly ILogger<CanticoController> _logger;
        private readonly IApplicationServiceCantico _applicationServiceCantico;

        public CanticoController(IApplicationServiceCantico applicationServiceCantico,
            ILogger<CanticoController> logger)
        {
            _logger = logger;
            _applicationServiceCantico = applicationServiceCantico;
        }

        [HttpGet]
        [Authorize]
        [Route("/cantico/", Name = "CanticoGetAll")]
        [ProducesResponseType(typeof(CanticoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<CanticoDTO>> GetAll()
        {
            return Ok(_applicationServiceCantico.GetAll());
        }

        [HttpGet]
        [Authorize]
        [Route("/cantico/{id}", Name = "CanticoGetById")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(CanticoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<string> GetById(Guid id)
        {
            return Ok(_applicationServiceCantico.GetById(id));
        }

        [HttpGet]
        [Authorize]
        [Route("/cantico/search/{titulo}", Name = "CanticoGetByTitulo")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(CanticoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<CanticoDTO>> GetByTitulo(string titulo)
        {
            return Ok(_applicationServiceCantico.GetByTitulo(titulo));
        }

        [HttpPost]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(CanticoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] CanticoDTO canticoDto)
        {
            try
            {
                if (canticoDto == null)
                    return NotFound();

                _applicationServiceCantico.Add(canticoDto);
                return Ok("Cântico cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(CanticoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Put([FromBody] CanticoDTO canticoDto)
        {
            try
            {
                if (canticoDto == null)
                    return NotFound();

                _applicationServiceCantico.Update(canticoDto);

                return Ok("Cântico atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete()]
        [Authorize]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(CanticoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Delete([FromBody] CanticoDTO canticoDto)
        {
            try
            {
                if (canticoDto == null)
                    return NotFound();

                _applicationServiceCantico.Remove(canticoDto);

                return Ok("Cântico removido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
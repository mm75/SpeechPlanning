using System;
using System.Collections.Generic;
using System.Net.Mime;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Application.Interfaces;
using MarioMendonca.SpeechPlanning.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MarioMendonca.SpeechPlanning.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdiomaController : ControllerBase
    {
        private readonly ILogger<IdiomaController> _logger;
        private readonly IApplicationServiceIdioma _applicationServiceIdioma;

        public IdiomaController(IApplicationServiceIdioma applicationServiceIdioma,
            ILogger<IdiomaController> logger)
        {
            _logger = logger;
            _applicationServiceIdioma = applicationServiceIdioma;
        }

        [HttpGet]
        [Route("/idioma/", Name = "IdiomaGetAll")]
        [ProducesResponseType(typeof(IdiomaDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<Idioma>> GetAll()
        {
            return Ok(_applicationServiceIdioma.GetAll());
        }

        [HttpGet]
        [Route("/idioma/{id}", Name = "IdiomaGetById")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(IdiomaDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<string> GetById(Guid id)
        {
            return Ok(_applicationServiceIdioma.GetById(id));
        }

        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(IdiomaDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] IdiomaDTO idiomaDto)
        {
            try
            {
                if (idiomaDto == null)
                    return NotFound();

                _applicationServiceIdioma.Add(idiomaDto);
                return Ok("Idioma cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(IdiomaDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Put([FromBody] IdiomaDTO idiomaDto)
        {
            try
            {
                if (idiomaDto == null)
                    return NotFound();

                _applicationServiceIdioma.Update(idiomaDto);
                
                return Ok("Idioma atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete()]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(IdiomaDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Delete([FromBody] IdiomaDTO idiomaDto)
        {
            try
            {
                if (idiomaDto == null)
                    return NotFound();

                _applicationServiceIdioma.Remove(idiomaDto);
                
                return Ok("Idioma removido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
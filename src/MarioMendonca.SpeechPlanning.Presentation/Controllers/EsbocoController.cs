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
    public class EsbocoController : ControllerBase
    {
        private readonly ILogger<EsbocoController> _logger;
        private readonly IApplicationServiceEsboco _applicationServiceEsboco;

        public EsbocoController(IApplicationServiceEsboco applicationServiceEsboco,
            ILogger<EsbocoController> logger)
        {
            _logger = logger;
            _applicationServiceEsboco = applicationServiceEsboco;
        }

        [HttpGet]
        [Route("/esboco/", Name = "EsbocoGetAll")]
        [ProducesResponseType(typeof(EsbocoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<Esboco>> GetAll()
        {
            return Ok(_applicationServiceEsboco.GetAll());
        }

        [HttpGet]
        [Route("/esboco/{id}", Name = "EsbocoGetById")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(EsbocoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<string> GetById(Guid id)
        {
            return Ok(_applicationServiceEsboco.GetById(id));
        }

        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(EsbocoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] EsbocoDTO esbocoDto)
        {
            try
            {
                if (esbocoDto == null)
                    return NotFound();

                _applicationServiceEsboco.Add(esbocoDto);
                return Ok("Esboço cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(EsbocoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Put([FromBody] EsbocoDTO esbocoDto)
        {
            try
            {
                if (esbocoDto == null)
                    return NotFound();

                _applicationServiceEsboco.Update(esbocoDto);
                
                return Ok("Esboço atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete()]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(EsbocoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Delete([FromBody] EsbocoDTO esbocoDto)
        {
            try
            {
                if (esbocoDto == null)
                    return NotFound();

                _applicationServiceEsboco.Remove(esbocoDto);
                
                return Ok("Esboço removido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
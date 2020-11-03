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
    public class ProgramacaoController : ControllerBase
    {
        private readonly ILogger<ProgramacaoController> _logger;
        private readonly IApplicationServiceProgramacao _applicationServiceProgramacao;

        public ProgramacaoController(IApplicationServiceProgramacao applicationServiceProgramacao,
            ILogger<ProgramacaoController> logger)
        {
            _logger = logger;
            _applicationServiceProgramacao = applicationServiceProgramacao;
        }

        [HttpGet]
        [Route("/programacao/", Name = "ProgramacaoGetAll")]
        [ProducesResponseType(typeof(ProgramacaoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<Programacao>> GetAll()
        {
            return Ok(_applicationServiceProgramacao.GetAll());
        }

        [HttpGet]
        [Route("/programacao/{id}", Name = "ProgramacaoGetById")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProgramacaoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<string> GetById(Guid id)
        {
            return Ok(_applicationServiceProgramacao.GetById(id));
        }

        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProgramacaoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] ProgramacaoDTO programacaoDto)
        {
            try
            {
                if (programacaoDto == null)
                    return NotFound();

                _applicationServiceProgramacao.Add(programacaoDto);
                return Ok("Programação cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProgramacaoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Put([FromBody] ProgramacaoDTO programacaoDto)
        {
            try
            {
                if (programacaoDto == null)
                    return NotFound();

                _applicationServiceProgramacao.Update(programacaoDto);
                
                return Ok("Programação atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete()]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProgramacaoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Delete([FromBody] ProgramacaoDTO programacaoDto)
        {
            try
            {
                if (programacaoDto == null)
                    return NotFound();

                _applicationServiceProgramacao.Remove(programacaoDto);
                
                return Ok("Programação removida com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
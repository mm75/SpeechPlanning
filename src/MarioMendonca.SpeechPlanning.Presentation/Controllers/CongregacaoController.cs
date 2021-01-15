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
    public class CongregacaoController : ControllerBase
    {
        private readonly ILogger<CongregacaoController> _logger;
        private readonly IApplicationServiceCongregacao _applicationServiceCongregacao;

        public CongregacaoController(IApplicationServiceCongregacao applicationServiceCongregacao,
            ILogger<CongregacaoController> logger)
        {
            _logger = logger;
            _applicationServiceCongregacao = applicationServiceCongregacao;
        }

        [HttpGet]
        [Route("/congregacao/", Name = "CongregacaoGetAll")]
        [ProducesResponseType(typeof(CongregacaoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<CongregacaoDTO>> GetAll()
        {
            return Ok(_applicationServiceCongregacao.GetAll());
        }

        [HttpGet]
        [Route("/congregacao/{id}", Name = "CongregacaoGetById")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(CongregacaoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<string> GetById(Guid id)
        {
            return Ok(_applicationServiceCongregacao.GetById(id));
        }

        [HttpGet]
        [Route("/congregacao/search/{nome}", Name = "CongregacaoGetByNome")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(CongregacaoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<CongregacaoDTO>> GetByNome(string nome)
        {
            return Ok(_applicationServiceCongregacao.GetByNome(nome));
        }

        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(CongregacaoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] CongregacaoDTO congregacaoDto)
        {
            try
            {
                if (congregacaoDto == null)
                    return NotFound();

                _applicationServiceCongregacao.Add(congregacaoDto);
                return Ok("Congregação cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(CongregacaoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Put([FromBody] CongregacaoDTO congregacaoDto)
        {
            try
            {
                if (congregacaoDto == null)
                    return NotFound();

                _applicationServiceCongregacao.Update(congregacaoDto);
                
                return Ok("Congregação atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete()]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(CongregacaoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Delete([FromBody] CongregacaoDTO congregacaoDto)
        {
            try
            {
                if (congregacaoDto == null)
                    return NotFound();

                _applicationServiceCongregacao.Remove(congregacaoDto);
                
                return Ok("Congregação removida com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
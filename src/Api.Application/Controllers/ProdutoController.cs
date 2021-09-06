using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Canducci.Pagination;
using System.Collections.Generic;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : BaseController
    {
        private IProdutoService _service;
        public ProdutoController(IProdutoService service)
        {
            _service = service;
        } 

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        //   [Authorize("Bearer")]
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        //    [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProdutoEntity produto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Post(produto);
                if (result != null)
                {
                    return Ok("Concluido");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        //    [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ProdutoEntity produto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Put(produto);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        //    [Authorize("Bearer")]
        // [HttpDelete("{id}")]
        [HttpDelete]
        public async Task<ActionResult> Delete([FromBody] ProdutoEntity produto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Delete(produto));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }       

        [HttpGet("Listar")]
        public async Task<ActionResult> GetListProduto()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                return Ok(await _service.ListProduto());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}

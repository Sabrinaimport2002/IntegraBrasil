using IntegraBrasil.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasil.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EnderecoController : ControllerBase
    {
        public readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet("busca/{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarEndereco([FromRoute] string cep){
            var response = await _enderecoService.BuscarEnderecoPorCEP(cep);
            if(response.CodigoHttp == System.Net.HttpStatusCode.OK){
                return Ok(response.DadosRetorno);
            } else{
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}
using IntegraBrasil.DTOs;

namespace IntegraBrasil.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEnderecoPorCEP(string cep);
    }
}
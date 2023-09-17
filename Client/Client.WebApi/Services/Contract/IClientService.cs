using Client.WebApi.Models;

namespace Client.WebApi.Services.Contract
{
    public interface IClientService
    {
        Task<List<Clients>> GetList();
        Task<Clients> Get(int idClient);
    }
}

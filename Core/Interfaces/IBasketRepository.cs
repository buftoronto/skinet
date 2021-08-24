using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IBasketRepository
    {
        Task<CustomerBasket> GetBasketAsync(string basketId);
        Task<CustomerBasket> UpdateBaseketAsync(CustomerBasket basket);
        Task<bool> DeleteBasketAsync(string basketId);
    }
}
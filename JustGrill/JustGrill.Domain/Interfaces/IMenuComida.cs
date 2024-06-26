using JustGrill.Domain.Entities;
using JustGrill.Domain.Models;

namespace JustGrill.Domain.Interfaces
{
    public interface IMenuComida : IBaseRepository<MenuComida>
    {
        List<MenuComidaModel> GetMenuComida();
    }
}

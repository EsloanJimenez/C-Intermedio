using JustGrill.Domain.Entities;
using JustGrill.Domain.Models;

namespace JustGrill.Domain.Interfaces
{
    public interface IMenuBebida : IBaseRepository<MenuBebida>
    {
        List<MenuBebidaModel> GetMenuBebida();
    }
}

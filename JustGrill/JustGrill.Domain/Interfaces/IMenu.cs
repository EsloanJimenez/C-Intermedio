using JustGrill.Domain.Entities;

namespace JustGrill.Domain.Interfaces
{
    public interface IMenu
    {
        Task Save(Menu menu);
        Task Save(List<Menu> menuList);
        Task Update(Menu menu);
        Task Update(List<Menu> menuList);
        Task Get(int idMenu);
        Task<List<Menu>> GetAll();
    }
}

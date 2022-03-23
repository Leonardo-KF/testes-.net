using usuario.Models;

namespace webapi.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> FindUsers();

        Task<Usuario> FindUsers(int id);

        void AddUser(Usuario user);
        void UpdateUser(Usuario user);
        void DeleteUser(int id);

        Task<bool> SaveChangesAsync();
    }
}
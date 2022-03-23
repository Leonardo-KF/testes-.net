using usuario.Models;
using webapi.Data;

namespace webapi.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UserContext _context;
        public UsuarioRepository(UserContext context)
        {
            _context = context;
        }

        public void AddUser(Usuario user)
        {
            _context.Add(user);
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> FindUsers()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> FindUsers(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void UpdateUser(Usuario user)
        {
            throw new NotImplementedException();
        }


    }
}
using School.Core.Entities;
using School.Infrastructure.Interfaces;

namespace School.Infrastructure
{
    public class AdminRepo : GenericRepository<Admin>, IAdminRepo
    {
        public AdminRepo(SchoolContext context) : base(context)
        {
        }

        public Admin FindByLogin(string login, string password)
        {
            return _Context.Admins.FirstOrDefault(x => x.Login == login && x.Password == password);
        }
    }
}

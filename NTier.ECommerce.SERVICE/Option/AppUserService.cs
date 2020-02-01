using NTier.ECommerce.MODEL.Entity;
using NTier.ECommerce.SERVICE.Base;

namespace NTier.ECommerce.SERVICE.Option
{
    public class AppUserService:BaseService<AppUser>
    {

        public bool CheckLogin(string userName, string password)
        {
            return Any(x => x.Name == userName && x.Password == password);
        }

        /// <summary>
        /// eğer true dönerse bu kullanıcı daha önce kayıtlıdır.!!!
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool CheckUserName(string userName)
        {
            return Any(x => x.Name == userName);
        }

        public bool CheckEmail(string email)
        {
            return Any(x => x.Email == email);
        }

        public AppUser FindByUserName(string userName)
        {
            return GetByDefault(x => x.Name == userName);
        }
    }
}

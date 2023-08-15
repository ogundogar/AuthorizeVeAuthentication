using AuthorizeVeAuthentication.Models.IRepository.Kullanici;

namespace AuthorizeVeAuthentication.Models.Repository.Kullanici
{
    public class KullaniciReadRepository : ReadRepository<TbKullanici>,IKullaniciReadRepository
    {
        public KullaniciReadRepository(Context context) : base(context)
        {
        }
    }
}

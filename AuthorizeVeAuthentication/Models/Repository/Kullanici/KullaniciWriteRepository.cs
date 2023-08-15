using AuthorizeVeAuthentication.Models.IRepository.Kullanici;

namespace AuthorizeVeAuthentication.Models.Repository.Kullanici
{
    public class KullaniciWriteRepository : WriteRepository<TbKullanici>,IKullaniciWriteRepository
    {
        public KullaniciWriteRepository(Context context) : base(context)
        {
        }
    }
}

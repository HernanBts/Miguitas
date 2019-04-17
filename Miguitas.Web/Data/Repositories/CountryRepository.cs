namespace Miguitas.Web.Data.Repositories
{
    using Entities;

    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DataContext context) : base(context)
        {
        }
    }

}

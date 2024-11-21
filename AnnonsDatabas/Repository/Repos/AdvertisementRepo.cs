using AnnonsDatabas.Repository.Entities;

namespace AnnonsDatabas.Repository.Repos
{
    public class AdvertisementRepo
    {
        public DataContext _advertisements = new();

        public AdvertisementRepo()
        {
            _advertisements = new DataContext();
        }



        public List<Advertisement> GetAdvertisements()
        {
            List<Advertisement> advertisements = _advertisements.GetAdvertisements();

            //advertisements = _advertisements.GetAdvertisements();

            return advertisements;
        }
    }
}

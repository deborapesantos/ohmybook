using Newtonsoft.Json;
using OMB.Adapter.Repository.Entites;

namespace OMB.Adapter.Repository
{
    public class UserBookshelfRepository : IUserBookshelfRepository
    {
        private string _sampleJsonFilePath = System.IO.Path.Combine(@"C:\\Repository\\myrepo\\ohmybook\\src\\adapters\\OMB.Adapter.Repository\\Repositories\\" + "data.json");

        public UserBookshelfRepository()
        {
           
        }

        public UserBooksShelfEntity GetBookshelf()
        {
            try
            {
                using StreamReader reader = new(_sampleJsonFilePath);
                var json = reader.ReadToEnd();
                UserBooksShelfEntity books = JsonConvert.DeserializeObject<UserBooksShelfEntity>(json);
                return books;
            }
            catch (Exception ex)
            {
                throw new FileNotFoundException();
            }          
        }
    }
}

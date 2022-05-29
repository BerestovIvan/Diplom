using DAL.DbContext;
using DAL.RepositoriesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ImagesRepository : IImagesRepository
    {
        private ApplicationDbContext applicationDbContext;

        public ImagesRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public Task AddAProductImages(IEnumerable<string> pathList, int articleId)
        {
            throw new NotImplementedException();
        }
    }
}

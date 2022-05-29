using BLL.ServiceInterfaces;
using DAL.RepositoriesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ImagesService : IImagesService
    {

        private readonly IImagesRepository _imagesRepository;
        public ImagesService(IImagesRepository imagesRepository)
        {
            _imagesRepository = imagesRepository;
        }

        public Task AddProductImages(IEnumerable<string> pathList, int articleId)
        {
            throw new NotImplementedException();
        }
    }
}

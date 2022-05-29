using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RepositoriesInterfaces
{
    public interface IImagesRepository
    {
        public Task AddAProductImages(IEnumerable<string> pathList, int articleId);
    }
}

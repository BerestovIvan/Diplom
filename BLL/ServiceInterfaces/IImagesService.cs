using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IImagesService
    {
        public Task AddProductImages(IEnumerable<string> pathList, int articleId);
    }
}

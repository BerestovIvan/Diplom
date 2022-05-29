using BLL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public class CommentService : ICommentService
    {
        public Task<CommentModel> Create(CommentModel commentModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommentModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<CommentModel> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CommentModel> Update(CommentModel commentModel)
        {
            throw new NotImplementedException();
        }
    }
}

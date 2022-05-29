using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLL.ServiceInterfaces;
using AutoMapper;
using BLL.Models;
using Microsoft.AspNetCore.Http;
using Diplom.Models;

namespace WebForumMVC.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentService commentService;
        private readonly IMapper mapper;

        public CommentsController(ICommentService commentService, IMapper mapper)
        {
            this.commentService = commentService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var comments = await commentService.Get();
            return View(mapper.Map<CommentViewModel>(comments));
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var comment = await commentService.Get(id);

            if (comment == null)
            {
                return NotFound();
            }

            return View(mapper.Map<CommentViewModel>(comment));
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Text,ArticleId")] CommentPostModel comment)
        {
            return View();
        }       
    }
}

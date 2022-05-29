using System;
using AutoMapper;
using BLL.Models;
using BLL.ServiceInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Diplom.Models;

namespace WebForumMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ICategoryService topicService;
        private readonly IProductService articleService;
        private readonly IMapper mapper;
        public ProductController(IProductService articleService, ICategoryService topicService, IMapper mapper)
        {
            this.articleService = articleService;
            this.topicService = topicService;
            this.mapper = mapper;   
        }

        public async Task<IActionResult> Index(QueryParamsViewModel paramsViewModel)
        {
            return View();
        }

        public async Task<IActionResult> GetUserArticles(QueryParamsViewModel paramsViewModel)
        {

            return View();
        }

        public async Task<IActionResult> Details(Guid id)
        {

            return View();
        }

        [Authorize]
        public async Task<IActionResult> Create()
        {

            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Title,Text,CreatorId, TopicId")] ProductPostModel articlePostModel)
        {

            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public async Task<IActionResult> Edit(Guid id)
        {

            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Text,TopicId")] ProductPutModel article)
        {

            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public async Task<IActionResult> Delete(Guid id)
        {

            return View();
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {

            return RedirectToAction(nameof(Index));
        }
    }
}
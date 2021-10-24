using introDotNetCoreWithMVC.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introDotNetCoreWithMVC.controller
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            var post = new Post { Title = "MVC Mimarisi Nedir", Content = "Lorem İpsum dolor sit amet", Name = "türkay" };
            var comment = new List<Comment>
            {
                new Comment{Name ="aysin", Context="güzel paylaşım"},
                new Comment{Name ="melih", Context="aynı viewde bırden fazla işlem nasıl.."},

            };
            var model = new PostAndCommentViewModel { Post = post, Comments = comment };
            return View(model);
        }

        [HttpPost] //yorum yapılcak
        public IActionResult Index(Comment model)
        {
            return View();  //vt kaydet
        }
    }
}

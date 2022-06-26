using CoreMvcKamp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcKamp.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserName="Miraç"
                },
                new UserComment
                {
                    ID=2,
                    UserName="Furkan"
                },
                new UserComment
                {
                    ID=3,
                    UserName="Ali"
                },
            };
            return View(commentValues);
        }
    }
}

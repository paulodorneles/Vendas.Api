using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Api.Application.Controllers
{
    public class BaseController : Controller
    {
        protected string myToken { get; set; }
        [ApiExplorerSettings(IgnoreApi = true)]
        private void LoadToken(ActionExecutingContext context)
        {
            var request = context.HttpContext.Request;
            var token = request.Headers["Authorization"];
            this.myToken = token.ToString().Replace("Bearer ", "");
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            LoadToken(context);
            base.OnActionExecuting(context);
        }
    }
}

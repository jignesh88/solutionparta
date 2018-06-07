using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SolutionPartA.Helpers;
using SolutionPartA.Models;

namespace SolutionPartA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetItemFromLinkedList(int index){
            var linkedList = SolutionPartA.Helpers.SolutionHelper.GetLinkedList();
            var result = linkedList.GetItemWithIndex(index);
            return new JsonResult(new JsonReturnViewModel { IsSuccess = true, Message = "sucess", Model = result.Number });
        }
        [HttpGet]
        public JsonResult GetReverseString(string requestString){
            var result = ReverseStatement.Reverse(requestString);
            return new JsonResult(new JsonReturnViewModel { IsSuccess = true, Message = "success", Model = result });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

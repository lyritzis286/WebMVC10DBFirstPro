using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.DTO;
using SchoolApp.Exceptions;
using SchoolApp.Services;
using SchoolApp.Core;

namespace SchoolApp.Controllers
{
    public class TeacherController : Controller
    {
        private readonly IApplicationService _applicationService;
        public List<Error> ErrorArray { get; set; } = [];

        public TeacherController(IApplicationService applicationService)
        {
            this._applicationService = applicationService;
        }

        [HttpGet]
        [Authorize(Roles = "TEACHER")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Signup(TeacherSignupDTO teacherSignupDTO)
        {
            if(!ModelState.IsValid)
            {
                return View(teacherSignupDTO);
            }
            try
            {
                await _applicationService.TeacherService.SignUpUserAsync(teacherSignupDTO);
                return RedirectToAction("Login", "User");
            }
            catch(EntityAlreadyExistsException)
            {
                ErrorArray.Add(new Error("", "Error on signup. Entity already exists", ""));
                ViewData["ErrorArray"] = ErrorArray;
                return View(teacherSignupDTO);
            }
            
        }
    }
}

using corepractice.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corepractice.Controllers
{
    public class ManagementController : Controller
    {
        private IUserRepository _userRepository;

        public ManagementController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ViewResult Index()
        {
            var model = _userRepository.GetAllUsers();
            return View(model);
        }

        // Rest of the code
    }
}

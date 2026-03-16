using JWTOneToOne.Data;
using JWTOneToOne.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTOneToOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdmissionController:ControllerBase
    {
        private readonly AppDbContext _context;

        public AdmissionController(AppDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult CreateAdmission(CollegeAdmission admission)
        {
            _context.Admissions.Add(admission);
            _context.SaveChanges();

            return Ok(admission);
        }
    }
}

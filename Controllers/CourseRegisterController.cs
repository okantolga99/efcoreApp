using efcoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace efcoreApp.Controllers
{
    public class CourseRegisterController:Controller
    {
        private readonly DataContext _context;
        public CourseRegisterController(DataContext context)
        {
            _context = context; 
        }
        public async Task<IActionResult> Index()
        {
            //include önemli!
            var courseRegisters = await _context.CourseRegisters.Include(x => x.Student).Include(x => x.Course).ToListAsync();
            return View(courseRegisters);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Students = new SelectList(await _context.Students.ToListAsync(),"StudentId","NameSurname");
            ViewBag.Courses = new SelectList(await _context.Courses.ToListAsync(), "CourseId","Title");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseRegister model)
        {
            model.RegisterDate = DateTime.Now;
           _context.CourseRegisters.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
            
        }
    }
}

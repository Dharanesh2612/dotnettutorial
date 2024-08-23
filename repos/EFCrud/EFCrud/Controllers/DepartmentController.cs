using EFCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCrud.Controllers
{
    public class DepartmentController : Controller
    {
        
        public CompanyContext companyContext;
        public DepartmentController(CompanyContext cc)
        {
            companyContext = cc;
        }
        public IActionResult Create()
        {
            //var dept1 = new Department() { Name = "Information Technology"};
            //var dept2 = new Department() { Name = "Human Resource" };
            //var dept3 = new Department() { Name = "Accounting" };

            //var deps = new List<Department>() { dept1, dept2, dept3 };
            //companyContext.AddRange(deps);
            //companyContext.SaveChanges();



            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            Department dept = await companyContext.Departments.Where(e => e.Id == id).FirstOrDefaultAsync();
            return View(dept);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Department dept)
        {
            companyContext.Update(dept);
            await companyContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> Create(Department dept)
        {
            companyContext.Add(dept);
            await companyContext.SaveChangesAsync();
            return RedirectToAction("Index");
         }

        



        public IActionResult Index()
        {
            return View(companyContext.Departments.AsNoTracking());
        }

        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {
            var dep = new Department() { Id = id };
            companyContext.Remove(dep);
            await companyContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DZUniversity.Pages.Courses
{
    public class DepartmentNamePageModelModel : PageModel
    {
        public SelectList DepartmentNameSL { get; set; }
        public void PopulateDepartmentsDropDownList(SchoolContext _context
                                        ,object selectedDepartment = null)
        {
          var departmetsQuery = from d in _context.Departments
                                orderby d.Name
                                select d;
            DepartmentNameSL = new SelectList(
                departmetsQuery.AsNoTracking(),
                "DepartmentID",
                "Name",
                selectedDepartment);
        }
    }
}

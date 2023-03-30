using _2011065349TranDinhTho_BigShool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2011065349TranDinhTho_BigShool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}
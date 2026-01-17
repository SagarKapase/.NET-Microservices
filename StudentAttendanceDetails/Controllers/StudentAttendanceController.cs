using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagement.Models;

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : Controller
    {
        // GET: StudentAttendanceController
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IEnumerable<StudentAttendanceDetailsModel> Get()
        {
            StudentAttendanceDetailsModel attendanceDetailsModel = new StudentAttendanceDetailsModel()
            {
                StudentID = 1,
                StudentName = "Sagar Kapase",
                AttendencePercentage = 92.5
            };
            StudentAttendanceDetailsModel attendanceDetailsModel2 = new StudentAttendanceDetailsModel()
            {
                StudentID = 2,
                StudentName = "Sagar Dada",
                AttendencePercentage = 88.0
            };
            List<StudentAttendanceDetailsModel> attendanceDetailsModels = new List<StudentAttendanceDetailsModel>();
            attendanceDetailsModels.Add(attendanceDetailsModel);
            attendanceDetailsModels.Add(attendanceDetailsModel2);
            return attendanceDetailsModels;
        }
    }
}

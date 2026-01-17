using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagement.Models;

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : Controller
    {
        // GET: StudentAdmissionController
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IEnumerable<StudentAdmissionDetailsModel> Get()
        {
            StudentAdmissionDetailsModel admissionDetailsModel = new StudentAdmissionDetailsModel()
            {
                StudentID = 1,
                StudentName = "John Doe",
                StudentClass = "10th Grade",
                DateofJoining = DateTime.Now
            };
            StudentAdmissionDetailsModel admissionDetailsModel2 = new StudentAdmissionDetailsModel()
            {
                StudentID = 2,
                StudentName = "Jane Smith",
                StudentClass = "9th Grade",
                DateofJoining = DateTime.Now
            };
            List<StudentAdmissionDetailsModel> admissionDetailsModels = new List<StudentAdmissionDetailsModel>();
            admissionDetailsModels.Add(admissionDetailsModel);
            admissionDetailsModels.Add(admissionDetailsModel2);
            return admissionDetailsModels;
        }
    }
}

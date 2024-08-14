//using Xunit;
//using Microsoft.AspNetCore.Mvc;
//using SIMS_SE06205.Controllers;
//using SIMS_SE06205.Models;

//namespace testfinal
//{
//    public class StudentControllerTests
//    {
//        [Fact]
//        public void AddStudent_ValidData_ReturnsRedirectToIndex()
//        {
//            // Arrange
//            var controller = new StudentController();
//            var student = new StudentViewModel
//            {

//                NameStudent = "John Doe",
//                Code = "S001",
//                Major = "Python",
//                Gender = "Male",
//                Adress = "123 Main St",
//                Class = "Kua"
//            };

//            // Act
//            var result = controller.Add(student);

//            // Assert
//            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
//            Assert.Equal("Index", redirectResult.ActionName);
//        }

//        [Fact]
//        public void AddStudent_InvalidData_ReturnsViewWithModel()
//        {
//            // Arrange
//            var controller = new StudentController();
//            var student = new StudentViewModel
//            {
//                Code = "", // Invalid: missing Code
//                NameStudent = "John Doe",
//                Major = "",
//                Gender = "",
//                Adress = "",
//                Class = ""
//            };
//            controller.ModelState.AddModelError("Code", "Required");

//            // Act
//            var result = controller.Add(student);

//            // Assert
//            var viewResult = Assert.IsType<ViewResult>(result);
//            Assert.Equal(student, viewResult.Model);
//        }
//        [Fact]
//        public void UpdateStudent_ValidData_ReturnsRedirectToIndex()
//        {
//            // Arrange
//            var controller = new StudentController();
//            var student = new StudentViewModel
//            {
//                Id = "1",
//                Code = "S001",
//                NameStudent = "John Doe",
//                Major = "Computer Science",
//                Gender = "Male",
//                Adress = "123 Main St",
//                Class = "CS101"
//            };

//            // Act
//            var result = controller.Update(student);

//            // Assert
//            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
//            Assert.Equal("Index", redirectResult.ActionName);
//        }

//        [Fact]
//        public void UpdateStudent_InvalidData_ReturnsViewWithModel()
//        {
//            // Arrange
//            var controller = new StudentController();
//            var student = new StudentViewModel
//            {
//                Id = "1",
//                Code = "S001",
//                NameStudent = "", // Invalid: missing NameStudent
//                Major = "Computer Science",
//                Gender = "Male",
//                Adress = "123 Main St",
//                Class = "CS101"
//            };
//            controller.ModelState.AddModelError("NameStudent", "Required");

//            // Act
//            var result = controller.Update(student);

//            // Assert
//            var viewResult = Assert.IsType<ViewResult>(result);
//            Assert.Equal(student, viewResult.Model);
//        }
//    }
//}
using Xunit;
using Microsoft.AspNetCore.Mvc;
using SIMS_SE06205.Controllers;
using SIMS_SE06205.Models;

namespace testfinal
{
    public class StudentControllerTests
    {
        [Fact]
            public void AddStudent_InvalidData_ReturnsViewWithModel()
            {
                // Arrange
                var controller = new StudentController();
                var student = new StudentViewModel
                {
                    NameStudent = "John Doe",
                    Code = "S001",
                    Major = "Python",
                    Gender = "Male",
                    Adress = "123 Main St",
                    Class = "Kua"
                };

                // Act
                var result = controller.Add(student);

                // Assert
                var redirectResult = Assert.IsType<RedirectToActionResult>(result);
                Assert.Equal("Index", redirectResult.ActionName);
            }

        [Fact]
        public void AddStudent_ValidData_ReturnsRedirectToIndex()
        {
            // Arrange
            var controller = new StudentController();
            var student = new StudentViewModel
            {
                Code = "", // Invalid: missing Code
                NameStudent = "John Doe",
                Major = "",
                Gender = "",
                Adress = "",
                Class = ""
            };
            controller.ModelState.AddModelError("Code", "Required");

            // Act
            var result = controller.Add(student);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(student, viewResult.Model);
        }

        [Fact]
        public void UpdateStudent_InvalidData_ReturnsViewWithModel()
     
        {
            // Arrange
            var controller = new StudentController();
            var student = new StudentViewModel
            {
                Id = "1",
                Code = "S001",
                NameStudent = "John Doe",
                Major = "Computer Science",
                Gender = "Male",
                Adress = "123 Main St",
                Class = "CS101"
            };

            // Act
            var result = controller.Update(student);

            // Assert
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectResult.ActionName);
        }

        [Fact]
         public void UpdateStudent_ValidData_ReturnsRedirectToIndex()
        {
            // Arrange
            var controller = new StudentController();
            var student = new StudentViewModel
            {
                Id = "1",
                Code = "S001",
                NameStudent = "", // Invalid: missing NameStudent
                Major = "Computer Science",
                Gender = "Male",
                Adress = "123 Main St",
                Class = "CS101"
            };
            controller.ModelState.AddModelError("NameStudent", "Required");

            // Act
            var result = controller.Update(student);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(student, viewResult.Model);
        }
    }
}


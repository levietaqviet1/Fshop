using NPLC_Assignment12.Excercise.Excercise3;
using Moq;

namespace NPLC_Assignment12.Excercise.UnitTest
{
    [TestFixture]
    public class EmployeeControllerTests
    {
        // Kiểm tra này xác minh rằng phương thức DeleteEmployee của bộ điều khiển
        // gọi phương thức DeleteEmployee của đối tượng lưu trữ với đúng ID
        [Test]
        public void DeleteEmployee_WhenCalled_DeleteTheEmployeeFromDb()
        {
            // Tạo bản mô phỏng của giao diện IEmployeeStorage
            var storage = new Mock<IEmployeeStorage>();

            // Tạo một lớp EmployeeController, truyền vào đối tượng giả
            var controller = new EmployeeController(storage.Object);

            // Gọi phương thức DeleteEmployee của bộ điều khiển có ID là 1
            controller.DeleteEmployee(1);

            // Xác minh rằng phương thức DeleteEmployee của đối tượng lưu trữ đã được gọi với ID là 1
            storage.Verify(s => s.DeleteEmployee(1));
        }
    }
}

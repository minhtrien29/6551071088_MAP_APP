using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Models
{
    // Cần kế thừa từ DbContext để sử dụng các phương thức OnConfiguring và UseSqlServer
    public partial class HotelManagementContext : DbContext
    {
        // Đã đổi Server thành tên máy của bạn và thêm TrustServerCertificate=True để tránh lỗi
        private const string ConnectionString = "Server=LAPTOP-VIKH9RJL\\SQLEXPRESS;Database=HotelManagement;Trusted_Connection=True;TrustServerCertificate=True;";

        // Constructor không tham số để dùng: new HotelManagementContext()
        public HotelManagementContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
    }
}
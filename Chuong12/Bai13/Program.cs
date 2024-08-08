//13) Viết chương trình kết hợp giữa delegate và sự kiện để minh họa một đồng hồ điện tử thể hiện
//giờ hiện hành trên màn hình console

using System;
using System.Threading;
using static DongHoDienTu;

public class DongHoDienTu
{
    // Khai báo delegate cho sự kiện giờ thay đổi
    public delegate void TimeChangedHandler(object sender, TimeChangedEventArgs e);

    // Khai báo sự kiện sử dụng delegate
    public event TimeChangedHandler TimeChanged;

    private Timer _timer;

    public DongHoDienTu()
    {
        // Khởi tạo Timer và đặt khoảng thời gian cập nhật
        _timer = new Timer(OnTimedEvent, null, 0, 1000); // Cập nhật mỗi giây
    }

    private void OnTimedEvent(object state)
    {
        // Tạo đối tượng TimeChangedEventArgs với giờ hiện tại
        TimeChangedEventArgs args = new TimeChangedEventArgs
        {
            CurrentTime = DateTime.Now
        };

        // Kích hoạt sự kiện
        TimeChanged?.Invoke(this, args);
    }
}

// Đối tượng chứa thông tin về giờ thay đổi
public class TimeChangedEventArgs : EventArgs
{
    public DateTime CurrentTime { get; set; }
}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        DongHoDienTu clock = new DongHoDienTu();

        // Đăng ký phương thức xử lý sự kiện với sự kiện TimeChanged
        clock.TimeChanged += new TimeChangedHandler(OnTimeChanged); 

        // Giữ ứng dụng chạy
        Console.WriteLine("Nhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }

    private static void OnTimeChanged(object sender, TimeChangedEventArgs e)
    {
        // Xóa màn hình để cập nhật giờ mới
        Console.Clear();

        // Hiển thị giờ hiện tại
        Console.WriteLine("Giờ hiện tại: " + e.CurrentTime.ToString("HH:mm:ss"));
    }
}

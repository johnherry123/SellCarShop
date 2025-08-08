using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using CarShopMange.Entity;

namespace CarShopMange.UI
{
    public partial class main : Window
    {
        public ObservableCollection<SanPham> DanhSachSanPham { get; set; }
        public ObservableCollection<User> lstUser { get; set; }
        public ObservableCollection<UserRole> lstUserRole { get; set; }
        public ObservableCollection<Role> lstRole { get; set; }
        public ObservableCollection<User> lstCustomer { get; set; }
        public ObservableCollection<User> lstEmployee { get; set; }
        public main()
        {
            

            DanhSachSanPham = new ObservableCollection<SanPham>
            {
                new SanPham { Ten = "Áo thun nam", Gia = "120.000đ", HinhAnh = "Images/ao1.jpg" },
                new SanPham { Ten = "Áo sơ mi nữ", Gia = "220.000đ", HinhAnh = "Images/ao2.jpg" },
                new SanPham { Ten = "Quần jeans", Gia = "350.000đ", HinhAnh = "Images/quan1.jpg" },
                new SanPham { Ten = "Váy công sở", Gia = "450.000đ", HinhAnh = "Images/vay1.jpg" },
                new SanPham { Ten = "Túi xách thời trang", Gia = "600.000đ", HinhAnh = "Images/tui1.jpg" },
                new SanPham { Ten = "Giày thể thao", Gia = "750.000đ", HinhAnh = "Images/giay1.jpg" },
            };
            lstUser = new ObservableCollection<User>
            {
                new User { userID = 1, userName = "admin01", email = "admin01@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1990, 1, 1), phoneNumber = "+84123456701" },
      
                new User { userID = 2, userName = "customer01", email = "customer01@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1991, 2, 2), phoneNumber = "+84123456702" },
                new User { userID = 3, userName = "customer02", email = "customer02@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1992, 3, 3), phoneNumber = "+84123456703" },
                new User { userID = 4, userName = "customer03", email = "customer03@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1993, 4, 4), phoneNumber = "+84123456704" },
                new User { userID = 5, userName = "customer04", email = "customer04@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1994, 5, 5), phoneNumber = "+84123456705" },
                new User { userID = 6, userName = "customer05", email = "customer05@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1995, 6, 6), phoneNumber = "+84123456706" },
                new User { userID = 7, userName = "customer06", email = "customer06@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1996, 7, 7), phoneNumber = "+84123456707" },
                new User { userID = 8, userName = "customer07", email = "customer07@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1997, 8, 8), phoneNumber = "+84123456708" },
                new User { userID = 9, userName = "customer08", email = "customer08@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1998, 9, 9), phoneNumber = "+84123456709" },
                new User { userID = 10, userName = "customer09", email = "customer09@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1999, 10, 10), phoneNumber = "+84123456710" },
       
                new User { userID = 11, userName = "employee01", email = "employee01@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1990, 11, 11), phoneNumber = "+84123456711" },
                new User { userID = 12, userName = "employee02", email = "employee02@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1991, 12, 12), phoneNumber = "+84123456712" },
                new User { userID = 13, userName = "employee03", email = "employee03@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1992, 1, 13), phoneNumber = "+84123456713" },
                new User { userID = 14, userName = "employee04", email = "employee04@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1993, 2, 14), phoneNumber = "+84123456714" },
                new User { userID = 15, userName = "employee05", email = "employee05@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1994, 3, 15), phoneNumber = "+84123456715" },
                new User { userID = 16, userName = "employee06", email = "employee06@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1995, 4, 16), phoneNumber = "+84123456716" },
                new User { userID = 17, userName = "employee07", email = "employee07@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1996, 5, 17), phoneNumber = "+84123456717" },
                new User { userID = 18, userName = "employee08", email = "employee08@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1997, 6, 18), phoneNumber = "+84123456718" },
                new User { userID = 19, userName = "employee09", email = "employee09@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1998, 7, 19), phoneNumber = "+84123456719" },
                new User { userID = 20, userName = "employee10", email = "employee10@example.com", password = "Password123", entryDate = DateTime.Now, dateofBirth = new DateTime(1999, 8, 20), phoneNumber = "+84123456720" }

            };
            lstRole = new ObservableCollection<Role>
            {
                 new Role { roleID = 1, roleName = "Admin" },
                 new Role { roleID = 2, roleName = "Customer" },
                 new Role { roleID = 3, roleName = "Employee" }
            };
            lstUserRole = new ObservableCollection<UserRole>
            {
                new UserRole { userID = 1, roleID = 1 },
                new UserRole { userID = 2, roleID = 2 },
                new UserRole { userID = 3, roleID = 2 },
                new UserRole { userID = 4, roleID = 2 },
                new UserRole { userID = 5, roleID = 2 },
                new UserRole { userID = 6, roleID = 2 },
                new UserRole { userID = 7, roleID = 2 },
                new UserRole { userID = 8, roleID = 2 },
                new UserRole { userID = 9, roleID = 2 },
                new UserRole { userID = 10, roleID = 2 },
                new UserRole { userID = 11, roleID = 3 },
                new UserRole { userID = 12, roleID = 3 },
                new UserRole { userID = 13, roleID = 3 },
                new UserRole { userID = 14, roleID = 3 },
                new UserRole { userID = 15, roleID = 3 },
                new UserRole { userID = 16, roleID = 3 },
                new UserRole { userID = 17, roleID = 3 },
                new UserRole { userID = 18, roleID = 3 },
                new UserRole { userID = 19, roleID = 3 },
                new UserRole { userID = 20, roleID = 3 }
            };
            foreach (var u in lstUser)
            {
                var urs = lstUserRole
                    .Where(ur => ur.userID == u.userID)
                    .Select(ur =>
                    {
                        ur.user = u;
                        ur.role = lstRole.First(r => r.roleID == ur.roleID);
                        return ur;
                    })
                    .ToList();

                u.userRole = urs; 
            }
            lstCustomer = new ObservableCollection<User>(
                lstUser
                    .Join(lstUserRole, u => u.userID, ur => ur.userID, (u, ur) => new { u, ur })
                    .Join(lstRole, x => x.ur.roleID, r => r.roleID, (x, r) => new { x.u, r })
                    .Where(t => t.r.roleName == "Customer")   
                    .Select(t => t.u)
            );
            lstEmployee = new ObservableCollection<User>(
                lstUser
                    .Join(lstUserRole, u => u.userID, ur => ur.userID, (u, ur) => new { u, ur })
                    .Join(lstRole, x => x.ur.roleID, r => r.roleID, (x, r) => new { x.u, r })
                    .Where(t => t.r.roleName == "Employee")
                    .Select(t => t.u)
            );
            InitializeComponent();
            this.DataContext = this;

            this.StateChanged += (s, e) => UpdateWindowClip();
            this.SizeChanged += (s, e) => { if (this.WindowState == WindowState.Normal) UpdateWindowClip(); };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Sidebar.Tag = true;
            UpdateWindowClip();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Sidebar_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && int.TryParse(btn.TabIndex.ToString(), out int index))
            {
                MainTabControl.SelectedIndex = index;
            }
        }

        private void ToggleSidebar_Click(object sender, RoutedEventArgs e)
        {
            bool isOpen = (bool)Sidebar.Tag;
            Sidebar.Width = isOpen ? 50 : 200;
            Sidebar.Tag = !isOpen;
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = this.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void UpdateWindowClip()
        {
            if (this.WindowState == WindowState.Normal)
            {
                MainBorder.CornerRadius = new CornerRadius(20);

                Dispatcher.BeginInvoke(new Action(() =>
                {
                    this.Clip = new RectangleGeometry
                    {
                        Rect = new Rect(0, 0, this.ActualWidth, this.ActualHeight),
                        RadiusX = 20,
                        RadiusY = 20
                    };
                }), DispatcherPriority.Render);
            }
            else
            {
                this.Clip = null;
                MainBorder.CornerRadius = new CornerRadius(0);
            }
        }

        public class SanPham
        {
            public string Ten { get; set; }
            public string Gia { get; set; }
            public string HinhAnh { get; set; }
        }

        private void MainTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

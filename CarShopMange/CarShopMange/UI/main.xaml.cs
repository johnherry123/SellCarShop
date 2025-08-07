using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CarShopMange.UI
{
    public partial class main : Window
    {
        public ObservableCollection<SanPham> DanhSachSanPham { get; set; }

        public main()
        {
            InitializeComponent();

            DanhSachSanPham = new ObservableCollection<SanPham>
            {
                new SanPham { Ten = "Áo thun nam", Gia = "120.000đ", HinhAnh = "Images/ao1.jpg" },
                new SanPham { Ten = "Áo sơ mi nữ", Gia = "220.000đ", HinhAnh = "Images/ao2.jpg" },
                new SanPham { Ten = "Quần jeans", Gia = "350.000đ", HinhAnh = "Images/quan1.jpg" },
                new SanPham { Ten = "Váy công sở", Gia = "450.000đ", HinhAnh = "Images/vay1.jpg" },
                new SanPham { Ten = "Túi xách thời trang", Gia = "600.000đ", HinhAnh = "Images/tui1.jpg" },
                new SanPham { Ten = "Giày thể thao", Gia = "750.000đ", HinhAnh = "Images/giay1.jpg" },
            };

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
    }
}

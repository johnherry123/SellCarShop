using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CarShopMange.UI
{
    /// <summary>
    /// Interaction logic for main.xaml
    /// </summary>
    public partial class main : Window
    {
        private bool _isSidebarCollapsed = true;
        public main()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Sidebar_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && int.TryParse(btn.Tag.ToString(), out int index))
            {

            }
        }

        private void ToggleSidebar_Click(object sender, RoutedEventArgs e)
        {
            bool isOpen = (bool)Sidebar.Tag;

            Sidebar.Width = isOpen ? 50 : 200;
            Sidebar.Tag = !isOpen;

            // Cập nhật lại layout nếu cần
            MainTabControl.Margin = new Thickness(isOpen ? 10 : 10); // Giữ khoảng cách content
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void MaximizeRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }



        private void UpdateWindowClip()
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.Clip = new RectangleGeometry
                {
                    Rect = new Rect(0, 0, this.ActualWidth, this.ActualHeight),
                    RadiusX = 20,
                    RadiusY = 20
                };
                MainBorder.CornerRadius = new CornerRadius(20);
            }
            else
            {
                this.Clip = null;
                MainBorder.CornerRadius = new CornerRadius(0);
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateWindowClip();
            Sidebar.Tag = true;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdateWindowClip();
        }
       

    }
}

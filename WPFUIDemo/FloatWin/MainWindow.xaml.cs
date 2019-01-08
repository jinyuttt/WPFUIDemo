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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FloatWin
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Background = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(TipToolAll))
            };
        }
        /// <summary>
        /// 窗口拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        void FloatWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.Topmost = true;
            this.Left = SystemParameters.WorkArea.Width - 300;
            this.Top = 300;
        }

        private static readonly string TipToolAll = "pack://application:,,,/Skin/images/TipToolMainHover.png";

        private void Window_Closed(object sender, EventArgs e)
        {

        }
    }
}

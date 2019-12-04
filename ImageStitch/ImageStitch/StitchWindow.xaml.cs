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

namespace ImageStitch
{
    /// <summary>
    /// StitchWindow.xaml 的交互逻辑
    /// </summary>
    public partial class StitchWindow : Window
    {
        public StitchWindow(params string[] files)
        {
            InitializeComponent();
        }

        private void Grid_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            var delta = e.Delta / 100f;

            this.scale.ScaleX += delta;
            this.scale.ScaleY += delta;
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton != MouseButtonState.Pressed)
                return;

            var grid = sender as Grid;
            var pos = e.GetPosition(grid);

            ShowStatus($"X= {pos.X},Y = {pos.Y}");

            //Canvas.SetLeft(grid, pos.X);
            //Canvas.SetTop(grid, pos.Y);
        }

        private void ShowStatus(string str)
        {
            this.status.Content = str;
        }
    }
}

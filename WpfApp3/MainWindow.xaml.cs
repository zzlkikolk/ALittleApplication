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

namespace WpfApp3 {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            System.Windows.MessageBox.Show("爱你哦", "❥(^_-)");
            Close();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e) {
            Button button = (Button)sender;
            Thickness thickness = new Thickness();
            Random random1 = new Random();

            
            double y= random1.Next(0, (int)main.Height-120);
            double z = random1.Next(0, (int)main.Width-45);
            Console.WriteLine("最宽"+main.Width+"最高"+main.Height);
            //设置方块的外边距
            if (y < this.main.Height && z < this.main.Width) {
                Console.WriteLine("高度"+y+"宽度"+z);
                thickness.Top = y;
                thickness.Left = z;
            } else {
                Button_MouseEnter(sender, e);
            }
            button.Margin =thickness ;
        }
    }
}

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

namespace Water
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a;
            a = main.Text + thing.Text + "是怎么回事呢？" + main.Text + "相信大家都很熟悉，但是" + main.Text + thing.Text + "是怎么回事呢？" + "下面就让小编带大家一起了解一下" + main.Text + thing.Text + "是怎么回事吧。" + main.Text + thing.Text + "，其实就是" + main.Text + thing.Text + "了。大家可能会感到很惊讶，" + main.Text + "怎么会" + thing.Text + "呢？但事实就是这样，小编也感到非常惊讶。那么这就是关于" + main.Text + thing.Text + "的事情啦！大家有什么想法呢";
            output.Text = a;
        }

        private void copy_Click(object sender, RoutedEventArgs e)
        {
            if (output.Text!="")
            {
                Clipboard.SetDataObject(output.Text);
            }
        }
    }
}

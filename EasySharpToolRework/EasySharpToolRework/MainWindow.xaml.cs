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
using MahApps.Metro;

namespace EasySharpToolRework
{
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow
    {
        //HyunMi Profile Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.joduska.me/forum/user/74542-hyunmi/");
        }

        //Push profile Button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.joduska.me/forum/user/282-push/");
        }

        //Forums Button
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.joduska.me/forum/");
        }

        //Announcements Button
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.joduska.me/forum/forum/6-announcements/");
        }

        //Anti-Cheat Button
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.joduska.me/forum/topic/2587-anti-cheat/");
        }
        
        //Help section
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.joduska.me/forum/forum/19-help/");
        }

        //Forum Rules
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.joduska.me/forum/forum-26/announcement-1-global-forum-rules/");
        }

        //Shoutbox
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.joduska.me/forum/shoutbox/");
        }

        //Vcredist
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://download.microsoft.com/download/2/E/6/2E61CFA4-993B-4DD4-91DA-3737CD5CD6E3/vcredist_x86.exe");
        }

        //net framework 5.4.1
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://download.microsoft.com/download/1/6/7/167F0D79-9317-48AE-AEDB-17120579F8E2/NDP451-KB2858728-x86-x64-AllOS-ENU.exe");
        }

        //DirectX
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://download.microsoft.com/download/1/6/7/167F0D79-9317-48AE-AEDB-17120579F8E2/NDP451-KB2858728-x86-x64-AllOS-ENU.exe");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

        }
    }
}

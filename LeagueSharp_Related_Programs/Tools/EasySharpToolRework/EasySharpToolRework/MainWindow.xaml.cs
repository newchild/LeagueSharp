using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using MahApps.Metro;

namespace EasySharpToolRework
{
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow
    { 
        private static SpellInfoWindow SpellInfoWindow = new SpellInfoWindow();
        public static bool DoesRegKeyExist(string valueName)
        {
            if (Registry.ClassesRoot.GetValue(valueName) == null)
            {
                return false;
            }
            return true;
        }

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

        //LoLBuilder
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://lolbuilder.net/premium/?hop=lolbuildaf#");
        }

        //LoLVOChanger
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.joduska.me/forum/topic/10293-lvoc-lol-vo-changer-change-in-game-voices-and-sounds-works-with-l/");
        }

        //SkillShotInfo
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            SpellDataBase SpellDataBaseMain = new SpellDataBase();
            SpellDataBaseMain.Init();
            //System.Diagnostics.Process.Start("Jeon_MissileDB.exe");
        }

        //LES
        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            Process LES = new Process();
            LES.StartInfo.WorkingDirectory = "LES";
            LES.StartInfo.FileName = "LESs.exe";
            LES.Start();
        }

        //L# Download
        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.joduska.me/forum/forum/7-l-download/");
        }

        //L# teamspeak
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://voice.joduska.me");
        }

        //Open Appdata
        private static String path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/LeagueSharp";
        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(path);
        }

        //clear Appdata
        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            Directory.Delete(path, true);
        }

        //install button fix
        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            if (DoesRegKeyExist("ls"))
                {
                    Registry.ClassesRoot.CreateSubKey("ls");
                }
                RegistryKey key = Registry.ClassesRoot.OpenSubKey("ls", true);
                string name = "URL Protocol";
                string str2 = "";
                key.SetValue(name, str2, RegistryValueKind.String);
                key.Close();
                MessageBox.Show("Registry key edited, Install button should be fixed try again.", "Important Message");
        }

        //L# database
        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://lsharp.wouter2203.com/");
        }
    }
}

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
using System.Speech.Synthesis;

namespace InstalledSpeechSynthVoicesGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static String[] installedVoices;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            {
                installedVoices = new String[14];
                Int64 i = 0;
                String VoiceName;
                foreach (InstalledVoice voice in synthesizer.GetInstalledVoices())
                {
                    VoiceInfo info = voice.VoiceInfo;
                    VoiceName = info.Name.ToString();
                    installedVoices.SetValue(VoiceName, i);
                    i++;
                }
            }
            Label1.Content = installedVoices.GetValue(0);
            Label2.Content = installedVoices.GetValue(1);
            Label3.Content = installedVoices.GetValue(2);
            Label4.Content = installedVoices.GetValue(3);
            Label5.Content = installedVoices.GetValue(4);
            Label6.Content = installedVoices.GetValue(5);
            Label7.Content = installedVoices.GetValue(6);
            Label8.Content = installedVoices.GetValue(7);
            Label9.Content = installedVoices.GetValue(8);
            Label10.Content = installedVoices.GetValue(9);
            Label11.Content = installedVoices.GetValue(10);
            Label12.Content = installedVoices.GetValue(11);
            Label13.Content = installedVoices.GetValue(12);
            Label14.Content = installedVoices.GetValue(13);
        }
    }
}

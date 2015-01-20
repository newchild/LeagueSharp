using System;
using System.Speech.Synthesis;

namespace InstalledSpeechSynthVoices
{
    class Program
    {
        static void Main(string[] args)
        {

            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                Console.WriteLine("Installed voices -");
                foreach (InstalledVoice voice in synth.GetInstalledVoices())
                {
                    VoiceInfo info = voice.VoiceInfo;
                    Console.WriteLine(" Voice Name: " + info.Name);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
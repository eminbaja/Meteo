using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Meteo_Utils;
using Meteo_Models;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Windows.UI.Core;
using System.Diagnostics;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Meteo
{
    public sealed partial class MainPage : Page
    {
        private static System.Threading.Timer aTimer;

        public MainPage()
        {
            this.InitializeComponent();
            aTimer = new System.Threading.Timer(RefreshData, null, 0, 15000);
        }
        public async void RefreshData(object StateInfo)
        {
            Debug.WriteLine("Chiamata Eseguita");
            Root obj = await Utils.getData();
            /*Thread.Sleep(100);
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Text_Block.Text = obj.ToString();
            });*/

        }
        /*private async void Button_Click(object sender, RoutedEventArgs e)
        {     
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            foreach (var voice in Windows.Media.SpeechSynthesis.SpeechSynthesizer.AllVoices)
            {
                if (voice.Language.StartsWith("it"))
                {
                    synth.Voice = voice;
                    break;
                }
            }
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("FORZA FIORENTINA");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }*/
        
    }
}
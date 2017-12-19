using Mobile.Output;
using Mobile.Phone;
using Mobile.Phone.Components.Charger;
using Mobile.Phone.Components.Playback;
using InterfacesForm.Output;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InterfacesForm
{
    public partial class MainForm : Form
    {
        private delegate T AbstractCreator<T>(IOutput output);

        private IOutput output;
        private Mobile.Phone.MobileBase mobile;
        private Dictionary<RadioButton, AbstractCreator<PlaybackBase>> playbackCreators;
        private Dictionary<RadioButton, AbstractCreator<ChargerBase>> chargerCreators;

        public MainForm()
        {
            InitializeComponent();

            output = new TextBoxOutput(textBoxOutput);
            mobile = new ModernMobile(output);

            playbackCreators = new Dictionary<RadioButton, AbstractCreator<PlaybackBase>>()
            {
                {radioButtonPlaybackSpeaker, (output) => new ExternalSpeaker(output)},
                {radioButtonPlaybackIphone, (output) => new IphoneHeadset(output)},
                {radioButtonPlaybackSamsung, (output) => new SamsungHeadset(output)},
                {radioButtonPlaybackUnofficialIphone, (output) => new UnofficialIphoneHeadset(output)}
            };
            chargerCreators = new Dictionary<RadioButton, AbstractCreator<ChargerBase>>()
            {
                {radioButtonChargerFast, (output) => new FastCharger(output) },
                {radioButtonChargerUsb, (output) => new USBCharger(output) }
            };
        }

        private void UpdateOutputEnabled()
        {
            buttonPlaybackUnplug.Enabled = mobile.PlaybackComponent != null;
            buttonChargerUnplug.Enabled = mobile.Charger != null;
        }

        private void buttonPlaybackUnplug_Click(object sender, System.EventArgs e)
        {
            PlaybackBase unpluggedPlayback = mobile.PlaybackComponent;
            mobile.PlaybackComponent = null;
            if (unpluggedPlayback != null)
            {
                output.WriteLine($"{unpluggedPlayback.GetType().Name} unplugged.");
            }

            UpdateOutputEnabled();
        }

        private void buttonChargerUnplug_Click(object sender, System.EventArgs e)
        {
            ChargerBase unpluggedCharger = mobile.Charger;
            mobile.Charge(null);
            if (unpluggedCharger != null)
            {
                output.WriteLine($"{unpluggedCharger.GetType().Name} unplugged.");
            }

            UpdateOutputEnabled();
        }

        private void buttonPlaybackPlug_Click(object sender, System.EventArgs e)
        {
            RadioButton radioButtonChecked = playbackCreators.Keys.Where((rb) => rb.Checked).First();
            AbstractCreator<PlaybackBase> playbackCreator = playbackCreators[radioButtonChecked];
            if (playbackCreator != null)
            {
                mobile.PlaybackComponent = playbackCreator.Invoke(output);
                mobile.Play(new object());
                UpdateOutputEnabled();
            }
        }

        private void buttonChargerPlug_Click(object sender, System.EventArgs e)
        {
            RadioButton radioButtonChecked = chargerCreators.Keys.Where((rb) => rb.Checked).First();
            AbstractCreator<ChargerBase> chargerCreator = chargerCreators[radioButtonChecked];
            if (chargerCreators != null)
            {
                mobile.Charge(chargerCreator.Invoke(output));
                UpdateOutputEnabled();
            }
        }
    }
}

using Interfaces.Output;
using Interfaces.Phone;
using Interfaces.Phone.Components.Charger;
using Interfaces.Phone.Components.Playback;
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
        private Mobile mobile;
        private Dictionary<RadioButton, AbstractCreator<IPlayback>> playbackCreators;
        private Dictionary<RadioButton, AbstractCreator<ICharger>> chargerCreators;

        public MainForm()
        {
            InitializeComponent();

            output = new TextBoxOutput(textBoxOutput);
            mobile = new ModernMobile(output);

            playbackCreators = new Dictionary<RadioButton, AbstractCreator<IPlayback>>()
            {
                {radioButtonPlaybackSpeaker, (output) => new ExternalSpeaker(output)},
                {radioButtonPlaybackIphone, (output) => new IphoneHeadset(output)},
                {radioButtonPlaybackSamsung, (output) => new SamsungHeadset(output)},
                {radioButtonPlaybackUnofficialIphone, (output) => new UnofficialIphoneHeadset(output)}
            };
            chargerCreators = new Dictionary<RadioButton, AbstractCreator<ICharger>>()
            {
                {radioButtonChargerFast, (output) => new FastCharger(output) },
                {radioButtonChargerUsb, (output) => new OrdinaryCharger(output) }
            };
        }

        private void UpdateOutputEnabled()
        {
            buttonPlaybackUnplug.Enabled = mobile.PlaybackComponent != null;
            buttonChargerUnplug.Enabled = mobile.Charger != null;
        }

        private void buttonPlaybackUnplug_Click(object sender, System.EventArgs e)
        {
            IPlayback unpluggedPlayback = mobile.PlaybackComponent;
            mobile.PlaybackComponent = null;
            if (unpluggedPlayback != null)
            {
                output.WriteLine($"{unpluggedPlayback.GetType().Name} unplugged.");
            }

            UpdateOutputEnabled();
        }

        private void buttonChargerUnplug_Click(object sender, System.EventArgs e)
        {
            ICharger unpluggedCharger = mobile.Charger;
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
            AbstractCreator<IPlayback> playbackCreator = playbackCreators[radioButtonChecked];
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
            AbstractCreator<ICharger> chargerCreator = chargerCreators[radioButtonChecked];
            if (chargerCreators != null)
            {
                mobile.Charge(chargerCreator.Invoke(output));
                UpdateOutputEnabled();
            }
        }
    }
}

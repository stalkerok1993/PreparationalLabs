﻿using System.Text;
using Interfaces.Phone.Components;
using Interfaces.Phone.Components.Screen;
using Interfaces.Phone.Graphics;
using Interfaces.Phone.Misc;
using Interfaces.Phone.Components.Playback;
using Interfaces.Phone.Components.Charger;
using Interfaces.Output;

namespace Interfaces.Phone
{
    public abstract class Mobile
    {
        public Battery Battery { get; set; }
        public Camera Cameras { get; set; }
        public Dynamic Dynamics { get; set; }
        public Keyboard Keyboards { get; set; }
        public Microphone Microphones { get; set; }
        public SIMCard SimCards { get; set; }
        public Size Size { get; set; }

        public abstract ScreenBase Screen { get; }

        public IPlayback PlaybackComponent { get; set; }

        public ICharger Charger { get; private set; }

        protected IOutput output;

        public Mobile(IOutput output)
        {
            this.output = output;
        }

        public void Show(IScreenImage screenImage)
        {
            Screen.Show(screenImage);
        }

        public string Description
        {
            get
            {
                var descriptionBuilder = new StringBuilder();
                descriptionBuilder.AppendLine($"Screen: {Screen}");

                return descriptionBuilder.ToString();
            }
        }

        public void Play(object data)
        {
            PlaybackComponent?.Play(data);
        }

        public void Charge(ICharger charger)
        {
            Charger = charger;
            Charger?.Charge(this);
        }
    }
}

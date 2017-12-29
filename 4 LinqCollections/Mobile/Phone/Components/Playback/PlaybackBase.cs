﻿using Mobile.Output;

namespace Mobile.Phone.Components.Playback
{
    public abstract class PlaybackBase
    {
        protected IOutput output;

        public PlaybackBase(IOutput output)
        {
            this.output = output;
        }

        public abstract void Play(object data);
    }
}

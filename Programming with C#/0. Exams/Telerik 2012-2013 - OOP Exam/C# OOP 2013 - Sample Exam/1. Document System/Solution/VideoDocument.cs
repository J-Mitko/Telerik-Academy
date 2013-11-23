﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentSystem
{
    public class VideoDocument : MultimediaDocument
    {
        public long? FrameRate { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.Equals("framerate"))
            {
                this.FrameRate = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));

            base.SaveAllProperties(output);
        }
    }
}
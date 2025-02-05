﻿using System;
using System.Threading;

namespace ModuleEvents
{ 
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // 1- define a delegate
        // 2- define an event
        // 3- Raise the event


        // EventHandler 
        // EventHandler<TEventArgs>
        
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public event EventHandler VideoEncoding;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(1000);
            
            OnVideoEncdoed(video);
        }

        
        protected virtual void OnVideoEncdoed(Video video)
    {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() {  Video = video });
        }
    }
}
﻿using Android.App;
using Android.OS;

namespace Shiny.Hosting;


public enum ActivityState
{
    Created,
    Resumed,
    Paused,
    Destroyed,
	SaveInstanceState,
    Started,
    Stopped
}


public record ActivityChanged(
    Activity Activity, 
    ActivityState State, 
    Bundle? StateBundle
);
using System;
using System.Collections.Generic;

namespace ubco.ovilab.ViconUnityStream
{
    [Serializable]
    public class ViconStreamData
    {
        public Dictionary<string, List<float>> markerPose;
        public Dictionary<string, List<string>> hierachy;
    }
}

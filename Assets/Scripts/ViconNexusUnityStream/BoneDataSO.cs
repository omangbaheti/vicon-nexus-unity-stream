using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.Hands;

    namespace ubco.ovilab.ViconUnityStream
    {
        public class BoneDataSO : ScriptableObject
        {
            public Dictionary<string, string> segmentChild = new();
            public Dictionary<string, string> segmentParent = new();
            public Handedness handedness = Handedness.Right;
            protected string segment_Arm = "Arm";
            protected string segment_Hand = "Hand";
            protected string segment_1D1 = "1D1";
            protected string segment_1D2 = "1D2";
            protected string segment_1D3 = "1D3";
            protected string segment_1D4 = "1D4";
            protected string segment_2D1 = "2D1";
            protected string segment_2D2 = "2D2";
            protected string segment_2D3 = "2D3";
            protected string segment_2D4 = "2D4";
            protected string segment_3D1 = "3D1";
            protected string segment_3D2 = "3D2";
            protected string segment_3D3 = "3D3";
            protected string segment_3D4 = "3D4";
            protected string segment_4D1 = "4D1";
            protected string segment_4D2 = "4D2";
            protected string segment_4D3 = "4D3";
            protected string segment_4D4 = "4D4";
            protected string segment_5D1 = "5D1";
            protected string segment_5D2 = "5D2";
            protected string segment_5D3 = "5D3";
            protected string segment_5D4 = "5D4";

            // Hand and arm markers
            protected string marker_FA2 = "FA2";
            protected string marker_FA1 = "FA1";
            protected string marker_WRA = "WRA";
            protected string marker_WRB = "WRB";

            // thumb markers
            protected string marker_TH1 = "TH1";
            protected string marker_TH2 = "TH2";
            protected string marker_TH3 = "TH3";
            protected string marker_TH3P = "TH3P";
            protected string marker_TH4 = "TH4";

            // index finger markers
            protected string marker_H2 = "H2";
            protected string marker_IF1 = "IF1";
            protected string marker_IF2 = "IF2";
            protected string marker_IF3 = "IF3";

            // middle finger markers
            protected string marker_H3 = "H3";
            protected string marker_TF1 = "TF1";
            protected string marker_TF2 = "TF2";
            protected string marker_TF3 = "TF3";

            // ring finger markers
            protected string marker_H4 = "H4";
            protected string marker_RF2 = "RF2";
            protected string marker_RF3 = "RF3";
            protected string marker_RF4 = "RF4";

            // pinky finger markers
            protected string marker_H5 = "H5";
            protected string marker_PF1 = "PF1";
            protected string marker_PF2 = "PF2";
            protected string marker_PF3 = "PF3";

            protected string finger_1 = "1";
            protected string finger_2 = "2";
            protected string finger_3 = "3";
            protected string finger_4 = "4";
            protected string finger_5 = "5";

            protected void Awake()
            {
                string prefix = handedness == Handedness.Right ? "R": "L";
                segment_1D1 = prefix + segment_1D1;
                segment_1D2 = prefix + segment_1D2;
                segment_1D3 = prefix + segment_1D3;
                segment_1D4 = prefix + segment_1D4;
                segment_2D1 = prefix + segment_2D1;
                segment_2D2 = prefix + segment_2D2;
                segment_2D3 = prefix + segment_2D3;
                segment_2D4 = prefix + segment_2D4;
                segment_3D1 = prefix + segment_3D1;
                segment_3D2 = prefix + segment_3D2;
                segment_3D3 = prefix + segment_3D3;
                segment_3D4 = prefix + segment_3D4;
                segment_4D1 = prefix + segment_4D1;
                segment_4D2 = prefix + segment_4D2;
                segment_4D3 = prefix + segment_4D3;
                segment_4D4 = prefix + segment_4D4;
                segment_5D1 = prefix + segment_5D1;
                segment_5D2 = prefix + segment_5D2;
                segment_5D3 = prefix + segment_5D3;
                segment_5D4 = prefix + segment_5D4;
                marker_FA2 = prefix + marker_FA2;
                marker_FA1 = prefix + marker_FA1;
                marker_WRA = prefix + marker_WRA;
                marker_WRB = prefix + marker_WRB;
                marker_TH1 = prefix + marker_TH1;
                marker_TH2 = prefix + marker_TH2;
                marker_TH3 = prefix + marker_TH3;
                marker_TH3P = prefix + marker_TH3P;
                marker_TH4 = prefix + marker_TH4;
                marker_H2 = prefix + marker_H2;
                marker_IF1 = prefix + marker_IF1;
                marker_IF2 = prefix + marker_IF2;
                marker_IF3 = prefix + marker_IF3;
                marker_H3 = prefix + marker_H3;
                marker_TF1 = prefix + marker_TF1;
                marker_TF2 = prefix + marker_TF2;
                marker_TF3 = prefix + marker_TF3;
                marker_H4 = prefix + marker_H4;
                marker_RF2 = prefix + marker_RF2;
                marker_RF3 = prefix + marker_RF3;
                marker_RF4 = prefix + marker_RF4;
                marker_H5 = prefix + marker_H5;
                marker_PF1 = prefix + marker_PF1;
                marker_PF2 = prefix + marker_PF2;
                marker_PF3 = prefix + marker_PF3;
                finger_1 = prefix + finger_1;
                finger_2 = prefix + finger_2;
                finger_3 = prefix + finger_3;
                finger_4 = prefix + finger_4;
                finger_5 = prefix + finger_5;

                segmentChild = new Dictionary<string, string>()
                {
                    //{segment_Arm, null},
                    {segment_Arm, segment_Hand},
                    {segment_Hand, segment_3D1},

                    {segment_1D1, segment_1D2},
                    {segment_1D2, segment_1D3},
                    {segment_1D3, segment_1D4},

                    {segment_2D1, segment_2D2},
                    {segment_2D2, segment_2D3},
                    {segment_2D3, segment_2D4},

                    {segment_3D1, segment_3D2},
                    {segment_3D2, segment_3D3},
                    {segment_3D3, segment_3D4},

                    {segment_4D1, segment_4D2},
                    {segment_4D2, segment_4D3},
                    {segment_4D3, segment_4D4},

                    {segment_5D1, segment_5D2},
                    {segment_5D2, segment_5D3},
                    {segment_5D3, segment_5D4},
                };

                segmentParent = segmentChild.ToDictionary(i => i.Value, i => i.Key);
            }
        }

        public class HandBoneData
        {
            public string name;
            public HandBoneData parent;
            public HandBoneData child;
            public List<string> boneMarkers;
            public int finger;
            public XRHandJointID jointID;
        }
    }

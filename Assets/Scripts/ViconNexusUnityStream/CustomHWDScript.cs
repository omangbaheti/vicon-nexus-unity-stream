﻿using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.XR.CoreUtils;

namespace ubco.ovilab.ViconUnityStream
{
    public class CustomHWDScript : CustomSubjectScript
    {
        [Header("HWD Settings")]
        [Tooltip("If set or game object has XROrigin will configure the XROrigin.")]
        [SerializeField] private XROrigin xrOrigin;

        [Header("SWD One Euro filter settings")]
        [Tooltip("Enables filter for position")]
        [SerializeField] private bool applyPosFilter = false;
        [Tooltip("Filter min cutoff for position filter")]
        [SerializeField] private float posFilterMinCutoff = 0.1f;
        [Tooltip("Beta value for position filter")]
        [SerializeField] private float posFilterBeta = 50;

        [Space()]
        [Tooltip("Enables filter for rotation")]
        [SerializeField] private bool applyRotFilter = false;
        [Tooltip("Filter min cutoff for rotation filter")]
        [SerializeField] private float rotFilterMinCutoff = 0.1f;
        [Tooltip("Beta value for rotation filter")]
        [SerializeField] private float rotFilterBeta = 50;

        private OneEuroFilter<Quaternion> rotFilter;
        private OneEuroFilter<Vector3> posFilter;
        [SerializeField] private float HMDCentreOffset;

        protected override void Start()
        {
            base.Start();

            if (xrOrigin == null)
            {
                xrOrigin = GetComponent<XROrigin>();
            }

            if (xrOrigin != null)
            {
                xrOrigin.RequestedTrackingOriginMode = XROrigin.TrackingOriginMode.Floor;
            }
        }

        /// <inheritdoc />
        private void OnValidate()
        {
            if (Application.isPlaying)
            {
                rotFilter = new OneEuroFilter<Quaternion>(90, rotFilterMinCutoff, rotFilterBeta);
                posFilter = new OneEuroFilter<Vector3>(90, posFilterMinCutoff, posFilterBeta);
            }
        }

        /// <inheritdoc />
        protected override Dictionary<string, Vector3> ProcessSegments(Dictionary<string, Vector3> segments, Data data)
        {
            Vector3 forward = segments["base2"] - segments["base1"];
            Vector3 up = Vector3.Cross(forward, segments["base3"] - segments["base4"]);
            if (forward == Vector3.zero || up == Vector3.zero) return segments;
            Quaternion rotation = Quaternion.LookRotation(forward, up);

            if (applyPosFilter)
            {
                segments["base1"] = posFilter.Filter(segments["base1"], Time.realtimeSinceStartup);
            }

            if (applyRotFilter)
            {
                rotation = rotFilter.Filter(rotation, Time.realtimeSinceStartup);
            }

            foreach (var key in segmentsRotation.Keys.ToArray())
            {
                segmentsRotation[key] = rotation;
            }
            Vector3 imaginaryCentre = segments["base1"] + forward.normalized * HMDCentreOffset;
            ViconXRLoader.TrySetXRDeviceData(imaginaryCentre * viconUnitsToUnityUnits, rotation);
            return segments;
        }
    }
}

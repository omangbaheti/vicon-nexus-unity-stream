using System.Collections.Generic;
using Unity.XR.CoreUtils.Collections;
using UnityEngine;

namespace ubco.ovilab.ViconUnityStream.Utils
{
    [CreateAssetMenu(fileName = "HandProperties", menuName = "ViconNexusUnityStream/HandProperties", order = 0)]
    public class HandProperties : ScriptableObject
    {
        [Tooltip("Base normal offset in unity units to place hand from marker positions")]
        [SerializeField] private float baseNormalOffset = 0.01f;
        
        [Tooltip("Base normal offset in unity units to place hand from marker positions")]
        [SerializeField] private float baseTangentialOffset = 0.01f;
    
        
        
        [Tooltip("Increasing or decreasing the normal offset value by a certain percentage.")] [Range(-100, 100)]
        [SerializeField] private float indexNormalOffset = 0f;
        [Tooltip("Increasing or decreasing the normal offset value by a certain percentage.")] [Range(-100, 100)]
        [SerializeField] private float middleNormalOffset = 0f;
        [Tooltip("Increasing or decreasing the normal offset value by a certain percentage.")] [Range(-100, 100)]
        [SerializeField] private float ringNormalOffset = 0f;
        [Tooltip("Increasing or decreasing the normal offset value by a certain percentage.")] [Range(-100, 100)]
        [SerializeField] private float littleNormalOffset = 0f;
        [Tooltip("Increasing or decreasing the normal offset value by a certain percentage.")] [Range(-100, 100)]
        [SerializeField] private float thumbNormalOffset = 0f;
        
        [Tooltip("Increasing or decreasing the normal offset value by a certain percentage.")] [Range(-100, 100)]
        [SerializeField] private float indexTangentialOffset = 0f;
        [Tooltip("Increasing or decreasing the normal offset value by a certain percentage.")] [Range(-100, 100)]
        [SerializeField] private float middleTangentialOffset = 0f;
        [Tooltip("Increasing or decreasing the normal offset value by a certain percentage.")] [Range(-100, 100)]
        [SerializeField] private float ringTangentialOffset = 0f;
        [Tooltip("Increasing or decreasing the normal offset value by a certain percentage.")] [Range(-100, 100)]
        [SerializeField] private float littleTangentialOffset = 0f;
        [Tooltip("Increasing or decreasing the normal offset value by a certain percentage.")] [Range(-100, 100)]
        [SerializeField] private float thumbTangentialOffset = 0f;
        
        [Tooltip("The ratio in which its applied to each joint")]
        [SerializeField] private SerializableDictionary<string, float> jointNormalOffsetRatio = new()
        {
            {"Proximal", 0.33f},
            {"Intermediate", 0.66f},
            {"Distal", 1f},
            {"Tip", 1f},
        };
        
        [Tooltip("The ratio in which its applied to each joint")]
        [SerializeField] private SerializableDictionary<string, float> jointTangetialOffsetRatios = new()
        {
            {"Proximal", 1f},
            {"Intermediate", 1f},
            {"Distal", 1f},
            {"Tip", 1f},
        };
        
        public Dictionary<string, float> JointNormalOffsetRatios
        {
            get => jointNormalOffsetRatio;
        }

        public Dictionary<string, float> JointTangetialOffsetRatios
        {
            get => jointTangetialOffsetRatios;
        }
        
        /// <summary>
        /// Base normal offset in unity units to place hand from marker positions
        /// </summary>
        public float BaseNormalOffset
        {
            get => baseNormalOffset;
            set => baseNormalOffset = value;
        }

        /// <summary>
        /// Increasing or decreasing the normal offset value of the thumb by a certain percentage.
        /// </summary>
        public float ThumbNormalOffset
        {
            get => thumbNormalOffset;
            set => thumbNormalOffset = value;
        }

        /// <summary>
        /// Increasing or decreasing the normal offset value of the index finger by a certain percentage.
        /// </summary>
        public float IndexNormalOffset
        {
            get => indexNormalOffset;
            set => indexNormalOffset = value;
        }

        /// <summary>
        /// Increasing or decreasing the normal offset value of the middle finger by a certain percentage.
        /// </summary>
        public float MiddleNormalOffset
        {
            get => middleNormalOffset;
            set => middleNormalOffset = value;
        }

        /// <summary>
        /// Increasing or decreasing the normal offset value of the ring finger by a certain percentage.
        /// </summary>
        public float RingNormalOffset
        {
            get => ringNormalOffset;
            set => ringNormalOffset = value;
        }

        /// <summary>
        /// Increasing or decreasing the normal offset value of the little finger by a certain percentage.
        /// </summary>
        public float LittleNormalOffset
        {
            get => littleNormalOffset;
            set => littleNormalOffset = value;
        }
        
        /// <summary>
        /// Base Tangential offset in unity units to place hand from marker positions
        /// </summary>
        public float BaseTangentialOffset
        {
            get => baseTangentialOffset;
            set => baseTangentialOffset = value;
        }

        /// <summary>
        /// Increasing or decreasing the Tangential offset value of the thumb by a certain percentage.
        /// </summary>
        public float ThumbTangentialOffset
        {
            get => thumbTangentialOffset;
            set => thumbTangentialOffset = value;
        }

        /// <summary>
        /// Increasing or decreasing the Tangential offset value of the index finger by a certain percentage.
        /// </summary>
        public float IndexTangentialOffset
        {
            get => indexTangentialOffset;
            set => indexTangentialOffset = value;
        }

        /// <summary>
        /// Increasing or decreasing the Tangential offset value of the middle finger by a certain percentage.
        /// </summary>
        public float MiddleTangentialOffset
        {
            get => middleTangentialOffset;
            set => middleTangentialOffset = value;
        }

        /// <summary>
        /// Increasing or decreasing the Tangential offset value of the ring finger by a certain percentage.
        /// </summary>
        public float RingTangentialOffset
        {
            get => ringTangentialOffset;
            set => ringTangentialOffset = value;
        }

        /// <summary>
        /// Increasing or decreasing the Tangential offset value of the little finger by a certain percentage.
        /// </summary>
        public float LittleTangentialOffset
        {
            get => littleTangentialOffset;
            set => littleTangentialOffset = value;
        }
        
    }
}
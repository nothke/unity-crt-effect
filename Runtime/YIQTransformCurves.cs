using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nothke.CRT
{
    [CreateAssetMenu(fileName = "YIQPreset", menuName = "YIQ Transform Curves", order = 0)]
    public class YIQTransformCurves : ScriptableObject
    {
        public AnimationCurve YCurve;
        public AnimationCurve IQCurve;
    }
}
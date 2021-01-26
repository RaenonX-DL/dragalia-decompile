/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class CtrlLightSatelliteData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _degreePerSec;
		[HideInInspector]
		[SerializeField]
		private bool _useTimeCurve;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _timeCurveToAngle;
		[HideInInspector]
		[SerializeField]
		private bool _isFollowCenter;
		[HideInInspector]
		[SerializeField]
		private bool _isSub;
		[HideInInspector]
		[SerializeField]
		private bool _isYinYang;
		[HideInInspector]
		[SerializeField]
		private float _yinyangDuration;
		[HideInInspector]
		[SerializeField]
		private float _iconOffsetY;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public float degreePerSec { get; }
		public bool useTimeCurve { get; }
		public AnimationCurve timeCurveToAngle { get; }
		public bool isFollowCenter { get; }
		public bool isSub { get; }
		public bool isYinYang { get; }
		public float yinyangDuration { get; }
		public float iconOffsetY { get; }
		public bool guarantee { get; }
	
		// Constructors
		public CtrlLightSatelliteData();
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class ExtraCameraData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private CameraModeExtraAction.StyleType _style;
		[HideInInspector]
		[SerializeField]
		private LookAtType _lookat;
		[HideInInspector]
		[SerializeField]
		private float _timespan;
		[HideInInspector]
		[SerializeField]
		private float _distance;
		[HideInInspector]
		[SerializeField]
		private Vector3 _angle;
		[HideInInspector]
		[SerializeField]
		private bool _clearReset;
		[HideInInspector]
		[SerializeField]
		private float _interpolationTime;
		[HideInInspector]
		[SerializeField]
		private bool _useInterpolateCurve;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _interpolateCurveDistance;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _interpolateCurveRotate;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _interpolateCurveLookAt;
		[HideInInspector]
		[SerializeField]
		private bool _useCameraShake;
		[HideInInspector]
		[SerializeField]
		private CameraController.ShakeType _shakeType;
		[HideInInspector]
		[SerializeField]
		private int _startShakeFrame;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _timeCurvePositionX;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _timeCurvePositionY;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _timeCurvePositionZ;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _timeCurveRotateX;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _timeCurveRotateY;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _timeCurveRotateZ;
		[HideInInspector]
		[SerializeField]
		private bool _useFovCurve;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _fov;
		[HideInInspector]
		[SerializeField]
		private string _skillCutInEffect;
		[HideInInspector]
		[SerializeField]
		private int _skillCutInEffectTrigger;
		[HideInInspector]
		[SerializeField]
		private int _skillCutInFaceEye;
		[HideInInspector]
		[SerializeField]
		private int _skillCutInFaceMouth;
		[HideInInspector]
		[SerializeField]
		private float _skillCutInCameraNear;
	
		// Properties
		public CameraModeExtraAction.StyleType style { get; }
		public LookAtType lookat { get; }
		public float timespan { get; }
		public float distance { get; }
		public Vector3 angle { get; }
		public bool clearReset { get; }
		public float interpolationTime { get; }
		public bool useInterpolateCurve { get; }
		public AnimationCurve interpolateCurveDistance { get; }
		public AnimationCurve interpolateCurveRotate { get; }
		public AnimationCurve interpolateCurveLookAt { get; }
		public bool useCameraShake { get; }
		public CameraController.ShakeType shakeType { get; }
		public int startShakeFrame { get; }
		public AnimationCurve timeCurvePositionX { get; }
		public AnimationCurve timeCurvePositionY { get; }
		public AnimationCurve timeCurvePositionZ { get; }
		public AnimationCurve timeCurveRotateX { get; }
		public AnimationCurve timeCurveRotateY { get; }
		public AnimationCurve timeCurveRotateZ { get; }
		public bool useFovCurve { get; }
		public AnimationCurve fov { get; }
		public string skillCutInEffect { get; }
		public int skillCutInEffectTrigger { get; }
		public int skillCutInFaceEye { get; }
		public int skillCutInFaceMouth { get; }
		public float skillCutInCameraNear { get; }
	
		// Nested types
		public enum LookAtType
		{
			Owner = 0,
			LocalPlayer = 1,
			StageCenter = 2,
			AreaAnchor = 3
		}
	
		// Constructors
		public ExtraCameraData();
	}
}

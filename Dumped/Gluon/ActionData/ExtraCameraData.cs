using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ExtraCameraData : ActionParts.PartsData
	{
		public enum LookAtType
		{
			Owner,
			LocalPlayer,
			StageCenter,
			AreaAnchor
		}

		[SerializeField]
		[HideInInspector]
		private CameraModeExtraAction.StyleType _style;

		[SerializeField]
		[HideInInspector]
		private LookAtType _lookat;

		[SerializeField]
		[HideInInspector]
		private float _timespan;

		[SerializeField]
		[HideInInspector]
		private float _distance;

		[SerializeField]
		[HideInInspector]
		private Vector3 _angle;

		[SerializeField]
		[HideInInspector]
		private bool _clearReset;

		[SerializeField]
		[HideInInspector]
		private float _interpolationTime;

		[SerializeField]
		[HideInInspector]
		private bool _useInterpolateCurve;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _interpolateCurveDistance;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _interpolateCurveRotate;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _interpolateCurveLookAt;

		[SerializeField]
		[HideInInspector]
		private bool _useCameraShake;

		[SerializeField]
		[HideInInspector]
		private CameraController.ShakeType _shakeType;

		[SerializeField]
		[HideInInspector]
		private int _startShakeFrame;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _timeCurvePositionX;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _timeCurvePositionY;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _timeCurvePositionZ;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _timeCurveRotateX;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _timeCurveRotateY;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _timeCurveRotateZ;

		[SerializeField]
		[HideInInspector]
		private bool _useFovCurve;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _fov;

		[SerializeField]
		[HideInInspector]
		private string _skillCutInEffect;

		[SerializeField]
		[HideInInspector]
		private int _skillCutInEffectTrigger;

		[SerializeField]
		[HideInInspector]
		private int _skillCutInFaceEye;

		[SerializeField]
		[HideInInspector]
		private int _skillCutInFaceMouth;

		[SerializeField]
		[HideInInspector]
		private float _skillCutInCameraNear;

		public CameraModeExtraAction.StyleType style => default(CameraModeExtraAction.StyleType);

		public LookAtType lookat => default(LookAtType);

		public float timespan => default(float);

		public float distance => default(float);

		public Vector3 angle => default(Vector3);

		public bool clearReset => default(bool);

		public float interpolationTime => default(float);

		public bool useInterpolateCurve => default(bool);

		public AnimationCurve interpolateCurveDistance => null;

		public AnimationCurve interpolateCurveRotate => null;

		public AnimationCurve interpolateCurveLookAt => null;

		public bool useCameraShake => default(bool);

		public CameraController.ShakeType shakeType => default(CameraController.ShakeType);

		public int startShakeFrame => default(int);

		public AnimationCurve timeCurvePositionX => null;

		public AnimationCurve timeCurvePositionY => null;

		public AnimationCurve timeCurvePositionZ => null;

		public AnimationCurve timeCurveRotateX => null;

		public AnimationCurve timeCurveRotateY => null;

		public AnimationCurve timeCurveRotateZ => null;

		public bool useFovCurve => default(bool);

		public AnimationCurve fov => null;

		public string skillCutInEffect => null;

		public int skillCutInEffectTrigger => default(int);

		public int skillCutInFaceEye => default(int);

		public int skillCutInFaceMouth => default(int);

		public float skillCutInCameraNear => default(float);
	}
}

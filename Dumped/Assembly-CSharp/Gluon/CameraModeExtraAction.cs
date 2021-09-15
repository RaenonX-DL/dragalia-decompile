/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CameraModeExtraAction : CameraModeBase
	{
		// Fields
		private StyleType _style;
		private float extraActionDistance;
		private GameObject extraActionTarget;
		private float extraActionTime;
		private Vector3 extraActionRotation;
		private Vector3 extraActionStartPos;
		private float cameraSpeed;
		private bool enableFog;
		private float fogStartDistance;
		private float fogEndDistance;
		public const float DEFAULT_INTERPOLATION = 0.5f;
		private float interpolationTime;
		private bool useCameraShake;
		private float startShakeTime;
		private float _beginDistance;
		private Vector3 _beginRotation;
		private Vector3 _beginLookAt;
		private Vector3 _preBackLookAt;
		public AnimationCurve _interpolateCurveDistance;
		public AnimationCurve _interpolateCurveRotate;
		public AnimationCurve _interpolateCurveLookAt;
		public AnimationCurve _curvePositionX;
		public AnimationCurve _curvePositionY;
		public AnimationCurve _curvePositionZ;
		public AnimationCurve _curveRotationX;
		public AnimationCurve _curveRotationY;
		public AnimationCurve _curveRotationZ;
		public bool _useFovCurve;
		public AnimationCurve _curveFov;
		private bool _needsClearSkillCutInCamera;
		private List<CharacterBase> _skillCutInCameraOtherCharas;
		private List<EffectObject> _skillCutInCameraHiddenEffects;
		private EffectObject _skillCutInCameraEffect;
		private float _skillCutInCameraNear;
		public Action<CameraModeExtraAction> setupSkillCutInCameraFunc;
	
		// Properties
		public StyleType style { get; }
	
		// Nested types
		public enum StyleType
		{
			STANDARD = 0,
			OLD = 1,
			FBX_PATH = 2,
			FBX_PATH_SKILLCUTIN = 3
		}
	
		private enum StandardCameraState
		{
			Init = 0,
			ToTarget = 1,
			Stay = 2,
			BackNormal = 3,
			End = 4
		}
	
		// Constructors
		public CameraModeExtraAction(CameraController controller);
	
		// Methods
		public void Initialize(StyleType style, GameObject target, float dist, Vector3 rot, float time, float interpolationTime_ = -1f);
		public void InitializeShakeCamera(int startShakeFlame, CameraController.ShakeType shaketype);
		public void Finish(bool rotate = true);
		public override void Update();
		private void UpdateOld();
		private bool UpdateCameraDistance();
		private void UpdateStandard();
		private void UpdateFbxPath(bool isPlayingSkillCutInCamera);
		private void moveCameraStandard(Vector3 targetLookAt, float t);
		private void moveCameraFbxPath(Vector3 basePos, float t, bool withTargetRotation);
		public void SetInterpolateCurve(AnimationCurve curveD, AnimationCurve curveR, AnimationCurve curveL);
		public void SetCameraPath(AnimationCurve curvePosX, AnimationCurve curvePosY, AnimationCurve curvePosZ, AnimationCurve curveRotX, AnimationCurve curveRotY, AnimationCurve curveRotZ, bool useFov, AnimationCurve curveFov);
		public void SetupSkillCutInCamera(int faceEye, int faceMouth, float near);
		public void SetupSkillCutInCameraEffect(string effectName, int effectTrigger);
		private bool NeedsHideEffectForSkillCutInCamera(EffectObject eo);
		public void ClearSkillCutInCamera();
		public static bool CanPlaySkillCutInCamera(StyleType type, CharacterBase owner);
		private void CtrlFog(float preDis);
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleCameraController : MonoBehaviour
	{
		// Fields
		public GrowthManaCircleScene scene;
		public Camera mainCamera;
		[HideInInspector]
		public bool isCameraAnimating;
		private ScreenSaverStatus screenSaverStatus;
		private Vector3 initialCameraPosition;
		private Vector3 initialCameraEulerAngles;
		private Vector3 finishCameraPosition;
		private Quaternion finishCameraRotation;
		private Vector3 offset;
		private Vector3 rotation;
		private Vector3 secondPosition;
		private Vector3 secondRotation;
		private Vector3 initialRootPosition;
		private Quaternion initialRootRotation;
		private Vector3 finishRootPosition;
		private Quaternion finishRootRotation;
		private float firstDelay;
		private float secondDelay;
		private float thirdDelay;
		private float firstDuration;
		private float secondDuration;
		private float screenSaverMoveSpeed;
		private GrowthManaCircleObjectSettings objectSettings;
		private GrowthManaCircleEffectSettings effectSettings;
		private GrowthManaCircleCameraSettings cameraSettings;
		private GrowthManaCircleModel model;
		private UnityEvent onCompleteEvent;
		private Sequence limitReleaseSequence;
		private float screenSaverY;
	
		// Nested types
		private enum ScreenSaverStatus
		{
			None = 0,
			Starting = 1,
			Doing = 2,
			Finishing = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public bool isSetEndPiecePos;
			public GrowthManaCircleCameraController __4__this;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _StartInitialCameraMove_b__0(float value);
			internal void _StartInitialCameraMove_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public GrowthManaCircleCameraController __4__this;
			public Vector3 targetCameraPos;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _StartScreenSaverMode_b__0(float value);
			internal void _StartScreenSaverMode_b__1();
		}
	
		// Constructors
		public GrowthManaCircleCameraController();
	
		// Methods
		private void Start();
		public UnityEvent SetupEvent();
		public void OnCameraAnimationStarted();
		public void OnCameraAnimationFinished();
		public void StartInitialCameraMove(bool isSetEndPiecePos = false);
		public void StartReleaseLimitCameraMove();
		private void StartCameraMove();
		public bool IsScreenSaverModeOn();
		public void StartScreenSaverMode();
		public bool CanFinishScreenSaverMode();
		public void FinishScreenSaverMode();
		private void Update();
		public void Reset();
		[CompilerGenerated]
		private void _StartReleaseLimitCameraMove_b__35_0();
		[CompilerGenerated]
		private void _StartCameraMove_b__36_0(float value);
		[CompilerGenerated]
		private void _StartCameraMove_b__36_1(float value);
		[CompilerGenerated]
		private void _StartCameraMove_b__36_2();
		[CompilerGenerated]
		private void _FinishScreenSaverMode_b__40_0(float value);
		[CompilerGenerated]
		private void _FinishScreenSaverMode_b__40_1();
	}
}

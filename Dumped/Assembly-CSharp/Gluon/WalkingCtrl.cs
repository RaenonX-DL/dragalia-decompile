/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class WalkingCtrl : MonoBehaviour
	{
		// Fields
		private State state;
		private FreeCameraStep subStepFreeCamera;
		private CameraController cameraController;
		private bool keepFreeCamera;
		private int ballRandomIndex;
		private float freeCameraWaitSecNow;
		private static readonly float freeCameraWaitSecIn;
		private static readonly float freeCameraWaitSecOut;
		private static readonly float freeCameraUpdateRatio;
		private static readonly float freeCameraInputScale;
		private static readonly float freeCameraDistLimitA;
		private static readonly float freeCameraDistLimitB;
		private static readonly float freeCameraDistMax;
		private static readonly float freeCameraHeightFirst;
		private static readonly float freeCameraHeightMinA;
		private static readonly float freeCameraHeightMinB;
		private static readonly float freeCameraTargetHeight;
		private static readonly float freeCameraZoomMin;
		private float freeCameraZoomLimitPlayerDist;
		private static readonly float freeCameraZoomRangeMin;
		private static readonly float freeCameraZoomRangeMax;
		private static readonly float freeCameraZoomOffsetFirst;
		private static readonly float freeCameraCameraRotXMin;
		private static readonly float freeCameraCameraRotXMax;
		private static readonly float freeCameraTargetRotXMin;
		private static readonly float freeCameraTargetRotXMax;
		private static readonly float freeCameraTargetRotXMargin;
		private static readonly float freeCameraRawRotXMin;
		private static readonly float freeCameraRawRotXMax;
		private Vector3 freeCameraPositionLog;
		private Vector3 freeCameraPositionNow;
		private Vector3 freeCameraPositionNext;
		private Vector3 freeCameraTargetLog;
		private Vector3 freeCameraTargetNow;
		private Vector3 freeCameraTargetNext;
		private Vector3 freeCameraEulerAnglesNow;
		private float freeCameraZoomLengthNow;
		private static readonly float freeCameraPinchCtrlScale;
		private bool freeCameraZoomCtrlLog;
		private float freeCameraPinchValueLog;
	
		// Nested types
		private enum State
		{
			None = 0,
			Normal = 1,
			FreeCamera = 2
		}
	
		private enum FreeCameraStep
		{
			Initialize = 0,
			CameraIn = 1,
			Control = 2,
			CameraOut = 3
		}
	
		// Constructors
		public WalkingCtrl();
		static WalkingCtrl();
	
		// Methods
		private void Start();
		private void OnDestroy();
		private bool CanUpdateCameraTransform();
		public bool IsFreeCamera();
		public void ChangeFreeCamera(bool flag);
		public void DispStatusBar(bool flag);
		private void Update();
		private bool UpdateFreeCamera();
		private Vector3 SetFreeCameraPosLimit(Vector3 pos);
		private void UpdateFreeCameraTransform();
		private void UpdateFreeCameraZoomPosLimit();
		private bool UpdateFreeCameraAuto();
		private void UpdateFreeCameraControl();
		public Vector3 GetFollowCameraTargetPos(Func<Vector3> getDefaultPosAction);
		public bool IsFollowCameraMoveSpeedDashAction();
		public void CatchBall(CharacterBase chara);
		public void ReleaseBall(CharacterBase chara);
		public bool SetActionSkill(int index);
		public bool CheckFollowerIdle(CharacterBase chara, ref Vector3 targetPos, ref float moveSpeed, ref bool ignoreMoveMargin);
		public string GetComboVoiceName(HumanCharacter chara);
		public string GetIntervalVoiceName(HumanCharacter chara);
		public string GetWinVoiceName(HumanCharacter chara);
	}
}

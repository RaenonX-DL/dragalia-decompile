/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.PostEffectParams;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class WalkingCtrl : MonoBehaviour
	{
		// Fields
		private State state;
		private FreeCameraStep subStepFreeCamera;
		private CameraController cameraController;
		private MainCameraCtrl mainCameraCtrl;
		private CameraGroup mainCameraGroup;
		private FilterType defaultFilterType;
		private bool keepFreeCamera;
		private bool isPlayerControllingCameraFlag;
		private int ballRandomIndex;
		private Queue<CharacterBase> units;
		private Dictionary<CharacterBase, int> unitIndexDic;
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
		private static readonly float freeCameraIgnoreCtrlMin;
	
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
		public bool IsPlayerControllingCamera();
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
		public bool IsFollower(CharacterBase chara);
		public CharacterBase GetFollowerCharacter();
		public int GetFollowerCharacterIndex();
		private void UpdateUnits();
		public void ChangeFollower(bool refreshOnly = false);
	}
}

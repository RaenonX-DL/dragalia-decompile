using System;
using System.Collections.Generic;
using Gluon.PostEffectParams;
using UnityEngine;

namespace Gluon
{
	public class WalkingCtrl : MonoBehaviour
	{
		private enum State
		{
			None,
			Normal,
			FreeCamera
		}

		private enum FreeCameraStep
		{
			Initialize,
			CameraIn,
			Control,
			CameraOut
		}

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

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private bool CanUpdateCameraTransform()
		{
			return default(bool);
		}

		public bool IsFreeCamera()
		{
			return default(bool);
		}

		public bool IsPlayerControllingCamera()
		{
			return default(bool);
		}

		public void ChangeFreeCamera(bool flag)
		{
		}

		public void DispStatusBar(bool flag)
		{
		}

		private void Update()
		{
		}

		private bool UpdateFreeCamera()
		{
			return default(bool);
		}

		private Vector3 SetFreeCameraPosLimit(Vector3 pos)
		{
			return default(Vector3);
		}

		private void UpdateFreeCameraTransform()
		{
		}

		private void UpdateFreeCameraZoomPosLimit()
		{
		}

		private bool UpdateFreeCameraAuto()
		{
			return default(bool);
		}

		private void UpdateFreeCameraControl()
		{
		}

		public Vector3 GetFollowCameraTargetPos(Func<Vector3> getDefaultPosAction)
		{
			return default(Vector3);
		}

		public bool IsFollowCameraMoveSpeedDashAction()
		{
			return default(bool);
		}

		public void CatchBall(CharacterBase chara)
		{
		}

		public void ReleaseBall(CharacterBase chara)
		{
		}

		public bool SetActionSkill(int index)
		{
			return default(bool);
		}

		public bool CheckFollowerIdle(CharacterBase chara, ref Vector3 targetPos, ref float moveSpeed, ref bool ignoreMoveMargin)
		{
			return default(bool);
		}

		public string GetComboVoiceName(HumanCharacter chara)
		{
			return null;
		}

		public string GetIntervalVoiceName(HumanCharacter chara)
		{
			return null;
		}

		public string GetWinVoiceName(HumanCharacter chara)
		{
			return null;
		}

		public bool IsFollower(CharacterBase chara)
		{
			return default(bool);
		}

		public CharacterBase GetFollowerCharacter()
		{
			return null;
		}

		public int GetFollowerCharacterIndex()
		{
			return default(int);
		}

		private void UpdateUnits()
		{
		}

		public void ChangeFollower(bool refreshOnly = false)
		{
		}
	}
}

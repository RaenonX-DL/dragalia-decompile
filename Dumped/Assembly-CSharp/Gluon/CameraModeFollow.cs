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
	public class CameraModeFollow : CameraModeBase
	{
		// Fields
		[CompilerGenerated]
		private CameraType _camType_k__BackingField;
		private Vector2 _sliderCur;
		private float atMoveSpeed;
		private float atMoveSpeedOnLongRangeAttack;
		private bool isDash;
		private float battleBaseSpeed;
		private float dashFrontLength;
		private float frontLengthVerticalRatio;
		private float minDistance;
		private float maxDistance;
		private float dashZoomOutLength;
		private float dashZoomOutTime;
		private float longRangeAttackZoomOutLength;
		private float longRangeAttackZoomOutTime;
		private float longRangeAttackZoomKeepTime;
		private float longRangeAttackFrontOffset;
		private float longRangeAttackFrontInBaseSpeed;
		private float longRangeAttackFrontOutBaseSpeed;
		private float dashBaseSpeed;
		private float moveSpeedCoefOnZoomKeepTime;
		private float lookAtOffsetDistance;
		private float dashTime;
		private float longRangeAttackTime;
		private float zoomKeepTime;
		private const float followDistanceCoefficientDefault = 0.2f;
		private float followDistanceCoefficient;
		private float zoomPinch;
		private float zoomPinchPrev;
		private Vector3 lastTargetPos;
		private float defaultDistance;
		[CompilerGenerated]
		private bool _isBattleReady_k__BackingField;
		[CompilerGenerated]
		private float _readyStartDistance_k__BackingField;
		[CompilerGenerated]
		private float _readyInterpolation_k__BackingField;
		private bool _isFollowing;
		private float raidReadyTime;
		private const float raidReadyTimeLimit = 2f;
		private bool raidReadyEnd;
		private static readonly string saveKey;
		private bool _isPrologueIntroductionCamera;
		private float prologueIntroductionCy;
		private float prologueIntroductionStartY;
		private bool enableZoom;
	
		// Properties
		public CameraType camType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float MinDistance { get; }
		public float MaxDistance { get; }
		private bool isBattleReady { [CompilerGenerated] get; [CompilerGenerated] set; }
		private float readyStartDistance { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float readyInterpolation { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isFollowing { get; set; }
		public bool isPrologueIntroductionCamera { get; set; }
	
		// Constructors
		public CameraModeFollow(CameraController controller);
		static CameraModeFollow();
	
		// Methods
		public void Initialize(CharacterBase target, float dist, Vector3 rot, float time);
		public void SetFollowCameraData(CameraController.FollowCameraData[] followCameraData, CameraType type);
		public override void Update();
		private void UpdateBattleReady();
		private bool UpdateRaidReady();
		private bool UpdatePrologueIntroduction();
		public void SetReadyParam(float dist);
		public void EndReady();
		public Vector3 GetTargetPosition();
		private Vector3 GetLookTargetDefault();
		private Vector3 GetLookTargetForChronos();
		private void CalcAtMoveSpeedOnLongRangeAttack(float baseSpeed);
		public void SaveFollowDistance();
		private void LoadFollowDistance();
		public void EnableZoom(bool enable);
	}
}

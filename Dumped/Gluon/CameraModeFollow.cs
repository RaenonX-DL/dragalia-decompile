using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class CameraModeFollow : CameraModeBase
	{
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

		private bool _isFollowing;

		private float raidReadyTime;

		private const float raidReadyTimeLimit = 2f;

		private bool raidReadyEnd;

		private static readonly string saveKey;

		private bool _isPrologueIntroductionCamera;

		private float prologueIntroductionCy;

		private float prologueIntroductionStartY;

		private bool enableZoom;

		public CameraType camType
		{
			[CompilerGenerated]
			get
			{
				return default(CameraType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float MinDistance => default(float);

		public float MaxDistance => default(float);

		private bool isBattleReady
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private float readyStartDistance
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float readyInterpolation
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isFollowing
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isPrologueIntroductionCamera
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public CameraModeFollow(CameraController controller)
		{
		}

		public void Initialize(CharacterBase target, float dist, Vector3 rot, float time)
		{
		}

		public void SetFollowCameraData(CameraController.FollowCameraData[] followCameraData, CameraType type)
		{
		}

		public override void Update()
		{
		}

		private void UpdateBattleReady()
		{
		}

		private bool UpdateRaidReady()
		{
			return default(bool);
		}

		private bool UpdatePrologueIntroduction()
		{
			return default(bool);
		}

		public void SetReadyParam(float dist)
		{
		}

		public void EndReady()
		{
		}

		public Vector3 GetTargetPosition()
		{
			return default(Vector3);
		}

		private Vector3 GetLookTargetDefault()
		{
			return default(Vector3);
		}

		private Vector3 GetLookTargetForChronos()
		{
			return default(Vector3);
		}

		private void CalcAtMoveSpeedOnLongRangeAttack(float baseSpeed)
		{
		}

		public void SaveFollowDistance()
		{
		}

		private void LoadFollowDistance()
		{
		}

		public void EnableZoom(bool enable)
		{
		}
	}
}

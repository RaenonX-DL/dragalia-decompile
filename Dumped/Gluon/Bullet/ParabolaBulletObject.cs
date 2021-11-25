using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon.Bullet
{
	public class ParabolaBulletObject : BulletObjectWithMarker
	{
		protected enum StateSlide
		{
			Init,
			MarkerRun,
			Fire,
			BulletRun,
			End
		}

		private class BoundInfo
		{
			public bool _prePlusY;

			public int numPerSec
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float stopHeight
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

			public float postStopTime
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

			public bool wallDisappear
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

			public float boundCoefficient
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

			public float minLengthOfBoundParabola
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

			public float maxLengthOfBoundParabola
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

			public bool autoPeriodOfBoundParabola
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

			public bool init
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool stop
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float time
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public Vector3 initPosition
			{
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public Vector3 direction
			{
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public void Clear()
			{
			}

			public void AddTime(float elapsed)
			{
			}

			public void Initialize(Vector3 pos, Vector3 dir, float velocity)
			{
			}

			public void StopBound()
			{
			}
		}

		private class MineInfo
		{
			public float duration
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

			public float range
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

			public bool isExplodeTimeUp
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

			public bool isExplodeHit
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

			public bool init
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

			public float time
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public void Clear()
			{
			}

			public void AddTime(float elapsed)
			{
			}
		}

		private class SlideInfo
		{
			public float time
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float duration
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

			public StateSlide stateSlide
			{
				[CompilerGenerated]
				get
				{
					return default(StateSlide);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Vector3 bulletFirePosition
			{
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Vector3 playerPosition
			{
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float durationAfterRush
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

			public float lengthOfMarker
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

			public ChargeMarker.eColorType markerType
			{
				[CompilerGenerated]
				get
				{
					return default(ChargeMarker.eColorType);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int triggerLanding
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int triggerRunning
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public void AddTime(float elapsed)
			{
			}

			public void ResetTime()
			{
			}
		}

		private float _velocityH;

		private float _velocityV;

		private Vector3 _holizonBasePosition;

		private float _gravity;

		private float gravityMagnification;

		private float _top;

		private int targetCharaIndex;

		private BoundInfo _boundInfo;

		private MineInfo _mineInfo;

		private SlideInfo _slideInfo;

		public float lifeTime
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

		public ParabolaBulletData.AimType aimType
		{
			[CompilerGenerated]
			get
			{
				return default(ParabolaBulletData.AimType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 fixedPosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ParabolaBulletData.ImpactType impactType
		{
			[CompilerGenerated]
			get
			{
				return default(ParabolaBulletData.ImpactType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool fireFromTop
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

		public float dropTime
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

		public bool isHopBullet
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

		public float lengthOfHopBullet
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

		public float lengthOfBoundBullet
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

		public Vector3 offsetPos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 targetOffsetPos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float topOffsetY
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

		protected override void Clear()
		{
		}

		public bool Initialize(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, string hitAttrLabel, float waitTime, Vector3 initialPosition, Vector3 initialDirection)
		{
			return default(bool);
		}

		protected override bool State_Init()
		{
			return default(bool);
		}

		protected override bool State_Fire()
		{
			return default(bool);
		}

		protected override bool State_Delay()
		{
			return default(bool);
		}

		public Vector3 GetPosFromT(float t)
		{
			return default(Vector3);
		}

		protected override bool State_BulletRun()
		{
			return default(bool);
		}

		protected override bool State_After()
		{
			return default(bool);
		}

		protected override bool State_End()
		{
			return default(bool);
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		public void SetupBound(int numPerSec, float stopHeight, float postStopTime, bool wallDisappear, float boundCoefficient, float minLengthOfBoundParabola, float maxLengthOfBoundParabola, bool autoPeriodOfBoundParabola)
		{
		}

		private void UpdateBound()
		{
		}

		public void SetupMine(float duration, float range, bool isExplodeTimeUp, bool isExplodeHit)
		{
		}

		private void UpdateMine()
		{
		}

		public void SetupSlide(float duration, float durationAfterRush, float lengthOfMarker, ChargeMarker.eColorType markerType, int triggerLanding, int triggerRunning)
		{
		}

		private void UpdateSlide()
		{
		}

		public void StateSlide_MarkerRun()
		{
		}

		public void StateSlide_Fire()
		{
		}

		public void StateSlide_BulletRun()
		{
		}

		public void StateSlide_End()
		{
		}
	}
}

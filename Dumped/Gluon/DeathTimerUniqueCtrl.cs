using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class DeathTimerUniqueCtrl : EnemyUniqueCtrl, ICollideCallback
	{
		public class TimeMarker
		{
			public enum Type
			{
				Accelerate,
				Rewind
			}

			public Type type
			{
				[CompilerGenerated]
				get
				{
					return default(Type);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public Vector3 position
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

			public EffectObject effectObject
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public TimeMarker(Type type_, Vector3 position_)
			{
			}
		}

		private bool _active;

		private Dictionary<int, int> _multiPartyDeathCountDic;

		private Dictionary<int, float> _fontColorCount;

		private int _actorIdSelf;

		private List<int> _multiIdList;

		private int _connectNum;

		private float _timer;

		private const float CountDownInterval = 1f;

		private const int CountFontColorThreshold = 10;

		private const float CountFontColorChangeSec = 0.33333334f;

		private CollisionHitAttribute _hitAttribute;

		private HitException _hitException;

		public Dictionary<int, int> multiPartyDeathCountDic => null;

		public TanatosHourGlassMultiPlayService MultiPlayService
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int countMax
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string burstEffectName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public List<TimeMarker> markers
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public float markerRadius
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

		public string markerEffectName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string fullChargeEffectName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string markerStartSeName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string markerFullChargeSeName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private bool activeTimeMarker
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

		private float elapsedTimeMarker
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

		public override void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public void Clear()
		{
		}

		public void Setup(int count_max, string hitAttrLabel, string effName)
		{
		}

		public void StartTimer()
		{
		}

		private void StopTimer(int actorId)
		{
		}

		public override void FastUpdate()
		{
		}

		private void UpdateUI()
		{
		}

		public void ShowSandTimerUI()
		{
		}

		public void CountSetSandTimerUI()
		{
		}

		private int AddDeathCount(int addCount)
		{
			return default(int);
		}

		private int AddDeathCount(int id, int addCount)
		{
			return default(int);
		}

		private void ResetCount()
		{
		}

		public void ResetCount(int id)
		{
		}

		public void ResetCountAll()
		{
		}

		private void Burst()
		{
		}

		public IEnumerator CoBurst()
		{
			return null;
		}

		public void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		public void OnNotCollided(CharacterBase chara)
		{
		}

		public bool IsExcept(CharacterBase chara)
		{
			return default(bool);
		}

		public void StartTimeMarker(float time)
		{
		}

		private void FinishTimeMarker()
		{
		}

		private void CheckInTimeMarker()
		{
		}
	}
}

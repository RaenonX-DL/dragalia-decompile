using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class TanatosUniqueCtrl : EnemyUniqueCtrl
	{
		private enum State
		{
			Normal,
			ResetWait
		}

		private class SandEffect
		{
			private EffectObject _effObj;

			private Transform _target;

			private Vector3 _startPos;

			private Vector3 relayPoint;

			private float _t;

			private Action _endAction;

			private bool _isEnd;

			private const float LeapTime = 0.25f;

			private const string EffectName01 = "EFF_RID_003_051";

			private const string EffectName02 = "EFF_RID_003_050";

			private const int EffectTriger01 = 1;

			private const int EffectTriger08 = 8;

			public bool IsEnd => default(bool);

			public SandEffect(Vector3 startPos, Transform target, [Optional] Action endAction)
			{
			}

			public void Update(float delta)
			{
			}

			private void PlayRecoverEffect()
			{
			}

			private Vector3 CalcPoint(float step)
			{
				return default(Vector3);
			}
		}

		private int _actorIdSelf;

		private List<int> _multiIdList;

		private Dictionary<int, int> _multiPartyDeathCountDic;

		private Dictionary<int, float> _fontColorCount;

		private EnemyCharacter _hourglassChara;

		private EnemyCharacter _deathCtrlChara;

		private int _deathActionID;

		private State _state;

		private float _deathCountResetTimer;

		private static TanatosUniqueCtrl _instance;

		private int _difficulty;

		private int _connectNum;

		private bool _isEyeEffectActive;

		private const int DefaultDeathCount = 60;

		private const float DefaultDeathCountResetTime = 2.5f;

		private const int SandEffectMax = 20;

		private const int DefaultCountRecoverValue = 10;

		private const int CountFontColorThreshold = 10;

		private const float CountFontColorChangeSec = 0.33333334f;

		private List<SandEffect> _sandEffList;

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

		public static bool IsTanatosBattle => default(bool);

		public int[] enemyDeadCountRecoverValue
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

		public int[] defaultDeathCountValue
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

		public override void Initialize()
		{
		}

		private void CreateEyeEffect()
		{
		}

		private void EffectCalcPos(Gluon.ActionData.EffectData data, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale, ref Transform attachNode)
		{
		}

		public override void FastUpdate()
		{
		}

		protected override void OnDisable()
		{
		}

		public void ShowSandTimerUI()
		{
		}

		public void CountSetSandTimerUI()
		{
		}

		public static void ResetCount()
		{
		}

		public void ResetCount(int id)
		{
		}

		public void ResetCountAll()
		{
		}

		public int AddDeathCount(int id, int addCount)
		{
			return default(int);
		}

		public int AddDeathCount(int addCount)
		{
			return default(int);
		}

		public void SetActionHourGlass(int actionID)
		{
		}

		public void CheckChiledSetUniqueBreakeAction()
		{
		}

		public static void EnemyDead(EnemyCharacter target)
		{
		}

		public void EnemyDeadCounterAllRecover(EnemyCharacter target, int recoverValue = 10)
		{
		}

		private void PlaySand(Vector3 startPos, Transform target, [Optional] Action func)
		{
		}
	}
}

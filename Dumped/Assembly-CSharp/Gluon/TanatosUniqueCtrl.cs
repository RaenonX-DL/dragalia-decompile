/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TanatosUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private int _actorIdSelf;
		private List<int> _multiIdList;
		private Dictionary<int, int> _multiPartyDeathCountDic;
		private Dictionary<int, float> _fontColorCount;
		private EnemyCharacter _hourglassChara;
		private EnemyCharacter _deathCtrlChara;
		private int _deathActionID;
		private State _state;
		private float _deathCountResetTimer;
		[CompilerGenerated]
		private TanatosHourGlassMultiPlayService _MultiPlayService_k__BackingField;
		private static TanatosUniqueCtrl _instance;
		private int[] _enemyDeadCountRecoverValue;
		private int[] _defaultDeathCountValue;
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
	
		// Properties
		public TanatosHourGlassMultiPlayService MultiPlayService { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static bool IsTanatosBattle { get; }
		public int[] enemyDeadCountRecoverValue { get; set; }
		public int[] defaultDeathCountValue { get; set; }
	
		// Nested types
		private enum State
		{
			Normal = 0,
			ResetWait = 1
		}
	
		private class SandEffect
		{
			// Fields
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
	
			// Properties
			public bool IsEnd { get; }
	
			// Constructors
			public SandEffect(Vector3 startPos, Transform target, Action endAction = null);
	
			// Methods
			public void Update(float delta);
			private void PlayRecoverEffect();
			private Vector3 CalcPoint(float step);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<SandEffect> __9__37_0;
			public static Action __9__48_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _FastUpdate_b__37_0(SandEffect obj);
			internal void _EnemyDead_b__48_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0
		{
			// Fields
			public int recoverValue;
	
			// Constructors
			public __c__DisplayClass49_0();
	
			// Methods
			internal void _EnemyDeadCounterAllRecover_b__0();
		}
	
		// Constructors
		public TanatosUniqueCtrl();
		static TanatosUniqueCtrl();
	
		// Methods
		public override void Initialize();
		private void CreateEyeEffect();
		private void EffectCalcPos(EffectData data, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale, ref Transform attachNode);
		public override void FastUpdate();
		protected override void OnDisable();
		public void ShowSandTimerUI();
		public void CountSetSandTimerUI();
		public static void ResetCount();
		public void ResetCount(int id);
		public void ResetCountAll();
		public int AddDeathCount(int id, int addCount);
		public int AddDeathCount(int addCount);
		public void SetActionHourGlass(int actionID);
		public void CheckChiledSetUniqueBreakeAction();
		public static void EnemyDead(EnemyCharacter target);
		public void EnemyDeadCounterAllRecover(EnemyCharacter target, int recoverValue = 10);
		private void PlaySand(Vector3 startPos, Transform target, Action func = null);
	}
}

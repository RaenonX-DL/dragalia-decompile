/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DeathTimerUniqueCtrl : EnemyUniqueCtrl, ICollideCallback
	{
		// Fields
		private bool _active;
		private Dictionary<int, int> _multiPartyDeathCountDic;
		private Dictionary<int, float> _fontColorCount;
		private int _actorIdSelf;
		private List<int> _multiIdList;
		[CompilerGenerated]
		private TanatosHourGlassMultiPlayService _MultiPlayService_k__BackingField;
		private int _connectNum;
		[CompilerGenerated]
		private int _countMax_k__BackingField;
		private float _timer;
		private const float CountDownInterval = 1f;
		private const int CountFontColorThreshold = 10;
		private const float CountFontColorChangeSec = 0.33333334f;
		private CollisionHitAttribute _hitAttribute;
		private HitException _hitException;
		[CompilerGenerated]
		private string _burstEffectName_k__BackingField;
		[CompilerGenerated]
		private readonly List<TimeMarker> _markers_k__BackingField;
		[CompilerGenerated]
		private float _markerRadius_k__BackingField;
		[CompilerGenerated]
		private string _markerEffectName_k__BackingField;
		[CompilerGenerated]
		private string _fullChargeEffectName_k__BackingField;
		[CompilerGenerated]
		private string _markerStartSeName_k__BackingField;
		[CompilerGenerated]
		private string _markerFullChargeSeName_k__BackingField;
		[CompilerGenerated]
		private bool _activeTimeMarker_k__BackingField;
		[CompilerGenerated]
		private float _elapsedTimeMarker_k__BackingField;
	
		// Properties
		public Dictionary<int, int> multiPartyDeathCountDic { get; }
		public TanatosHourGlassMultiPlayService MultiPlayService { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int countMax { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string burstEffectName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<TimeMarker> markers { [CompilerGenerated] get; }
		public float markerRadius { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string markerEffectName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string fullChargeEffectName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string markerStartSeName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string markerFullChargeSeName { [CompilerGenerated] get; [CompilerGenerated] set; }
		private bool activeTimeMarker { [CompilerGenerated] get; [CompilerGenerated] set; }
		private float elapsedTimeMarker { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public class TimeMarker
		{
			// Fields
			[CompilerGenerated]
			private Type _type_k__BackingField;
			[CompilerGenerated]
			private Vector3 _position_k__BackingField;
			[CompilerGenerated]
			private EffectObject _effectObject_k__BackingField;
	
			// Properties
			public Type type { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public Vector3 position { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public EffectObject effectObject { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Nested types
			public enum Type
			{
				Accelerate = 0,
				Rewind = 1
			}
	
			// Constructors
			public TimeMarker(Type type_, Vector3 position_);
		}
	
		[CompilerGenerated]
		private sealed class _CoBurst_d__74 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DeathTimerUniqueCtrl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoBurst_d__74(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DeathTimerUniqueCtrl();
	
		// Methods
		public override void Initialize();
		private void OnDestroy();
		public void Clear();
		public void Setup(int count_max, string hitAttrLabel, string effName);
		public void StartTimer();
		private void StopTimer(int actorId);
		public override void FastUpdate();
		private void UpdateUI();
		public void ShowSandTimerUI();
		public void CountSetSandTimerUI();
		private int AddDeathCount(int addCount);
		private int AddDeathCount(int id, int addCount);
		private void ResetCount();
		public void ResetCount(int id);
		public void ResetCountAll();
		private void Burst();
		[IteratorStateMachine]
		public IEnumerator CoBurst();
		public void OnCollided(GameObject target, bool isPropagation);
		public void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public void OnNotCollided(CharacterBase chara);
		public bool IsExcept(CharacterBase chara);
		public void StartTimeMarker(float time);
		private void FinishTimeMarker();
		private void CheckInTimeMarker();
	}
}

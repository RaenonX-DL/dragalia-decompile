/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionContainer : ActionBase
	{
		// Fields
		[CompilerGenerated]
		private string _name_k__BackingField;
		protected List<ActionParts> _actions;
		public List<CollisionHitAttribute> hitAttrList;
		public int actionId;
		private string _motionStateName;
		[CompilerGenerated]
		private CommonObjectStatus _target_k__BackingField;
		[CompilerGenerated]
		private CommonObjectStatus _targetObject_k__BackingField;
		[CompilerGenerated]
		private Vector3? _targetPosition_k__BackingField;
		[CompilerGenerated]
		private Quaternion _targetRotation_k__BackingField;
		[CompilerGenerated]
		private Vector3 _targetLocalScale_k__BackingField;
		private List<ChargeMarker> _markers;
		private Vector3 _lastMarkerPosition;
		public Dictionary<int, Vector3> dictTargetPos;
		private RunActionParameterSet _runActionParam;
		public int actionProductId;
		public int overrideActionProductId;
		[CompilerGenerated]
		private int _chargeLv_k__BackingField;
		[CompilerGenerated]
		private bool _isDamageCounterMode_k__BackingField;
		[CompilerGenerated]
		private ActionStartParameter _actionStartParam_k__BackingField;
		[CompilerGenerated]
		private bool _isResistClear_k__BackingField;
		[CompilerGenerated]
		private bool _isClearTargetReticleUIOff_k__BackingField;
		private List<string> _listClearVisibleOn;
		public List<int> activateIds;
		public Dictionary<CharacterBase, int> targetListForMultiBullet;
		[CompilerGenerated]
		private bool _blockSkillNextAction_k__BackingField;
		[CompilerGenerated]
		private Action<int> _onHitCountAdded_k__BackingField;
		[CompilerGenerated]
		private bool _isResetTargetEffect_k__BackingField;
		[CompilerGenerated]
		private int _hitCount_k__BackingField;
		[CompilerGenerated]
		private bool _hitCountEnabled_k__BackingField;
		public CollisionHitAttribute.CriticalStatus actionCriticalStatus;
		[CompilerGenerated]
		private uint _randomSeedOfMultiBullet_k__BackingField;
	
		// Properties
		public string name { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<ActionParts> actions { get; }
		public CommonObjectStatus target { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CommonObjectStatus targetObject { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3? targetPosition { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Quaternion targetRotation { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Vector3 targetLocalScale { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<ChargeMarker> markers { get; }
		public CommonObjectStatus currentMarker { get; }
		public Vector3 lastMarkerPosition { get; }
		public int chargeLv { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isDamageCounterMode { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ActionStartParameter actionStartParam { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isResistClear { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isClearTargetReticleUIOff { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<string> listClearVisibleOn { get; }
		public bool blockSkillNextAction { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action<int> onHitCountAdded { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isResetTargetEffect { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int hitCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool hitCountEnabled { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float MotionNormalizedTime { get; }
		public uint randomSeedOfMultiBullet { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<ActionParts, bool> __9__100_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Initialize_b__100_0(ActionParts parts);
		}
	
		// Constructors
		public ActionContainer(ActionContainerElement element, CharacterBase owner);
	
		// Methods
		public static void LoadElementDictionary(Dictionary<int, ActionContainerElement> dictionary, CharacterBase owner, string groupName, bool isOtherPlayer, List<int> skills = null, bool isShareSkill = false);
		public static void LoadElementDictionaryByPathForBR(Dictionary<int, ActionContainerElement> dictionary, CharacterBase owner, string path, bool isOtherPlayer);
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		public override void Reset();
		public override void Initialize(CharacterBase chara);
		public void PrepareDestroy();
		public override void Start();
		protected override void OnFinish();
		public override void Clear();
		public void OnMarkerClear(ChargeMarker marker, bool canRemove);
		public void ForceFinishState(int index);
		public void ForceClearMotionWait();
		public void SetConditionCheckResultForStartParam(int partIndex, bool value);
		protected override bool OnUpdate(float delta);
		protected override bool OnFixedUpdate(float delta);
		private void RegisterActionParts(ActionParts[] elements, CharacterBase owner);
		private ActionParts RegisterActionParts(ActionParts element, int partsIndex, CharacterBase owner);
		public void RegisterHitAttribute(ActionBase part, CollisionHitAttribute attr);
		public void RegisterTargetPosition(int id, Vector3 pos);
		private ActionParts CreateActionParts(ActionParts data_resource, long data_resource_id, CharacterBase owner);
		public override void SetSkillId(int id);
		public void SetTempoScale(float scale);
		public bool HasDamageHitAttribute(bool isIncludeDummy = false);
		public void ForceStopEffect(CharacterBase effectOwner);
		public bool IsFinishedActionMove();
		public bool IsContainsFireStockBullet();
		private bool HaveActionPartsCommandTargetReticleUIOFF();
		public void AddDamageOnDamageCounterMode(int damage);
		public bool IsOnlyGuardCounter();
		public int GetServantNum();
		public void SetAutoDelete(bool b);
		public void UpdateTargetTransform();
		public void SetOnHitCountAdded(Action<int> onHitCountAdded);
		public void ToggleHitCount(bool toOn);
		public void ToggleCriticalStatus(string dummyHitAttrLabel);
		public void SetActionCriticalStatus(CollisionHitAttribute.CriticalStatus criticalStatus);
		private void OnContainerHitCountAdded(int addHit);
	}
}

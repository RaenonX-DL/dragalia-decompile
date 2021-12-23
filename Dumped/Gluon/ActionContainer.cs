using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class ActionContainer : ActionBase
	{
		protected List<ActionParts> _actions;

		public List<CollisionHitAttribute> hitAttrList;

		public int actionId;

		private string _motionStateName;

		private List<ChargeMarker> _markers;

		private Vector3 _lastMarkerPosition;

		public Dictionary<int, Vector3> dictTargetPos;

		private RunActionParameterSet _runActionParam;

		public int actionProductId;

		public int overrideActionProductId;

		private List<string> _listClearVisibleOn;

		public List<int> activateIds;

		public Dictionary<CharacterBase, int> targetListForMultiBullet;

		public CollisionHitAttribute.CriticalStatus actionCriticalStatus;

		public string name
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

		public List<ActionParts> actions => null;

		public CommonObjectStatus target
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

		public CommonObjectStatus targetObject
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

		public Vector3? targetPosition
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

		public Quaternion targetRotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 targetLocalScale
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

		public List<ChargeMarker> markers => null;

		public CommonObjectStatus currentMarker => null;

		public Vector3 lastMarkerPosition => default(Vector3);

		public Vector3? parentBulletPosition
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

		public int chargeLv
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

		public bool isDamageCounterMode
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

		public ActionStartParameter actionStartParam
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

		public bool isResistClear
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

		public bool isClearTargetReticleUIOff
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

		public List<string> listClearVisibleOn => null;

		public bool blockSkillNextAction
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

		public Action<int> onHitCountAdded
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

		public bool isResetTargetEffect
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

		public int hitCount
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

		public bool hitCountEnabled
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

		public float MotionNormalizedTime => default(float);

		public uint randomSeedOfMultiBullet
		{
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static void LoadElementDictionary(Dictionary<int, ActionContainerElement> dictionary, CharacterBase owner, string groupName, bool isOtherPlayer, [Optional] List<int> skills, bool isShareSkill = false)
		{
		}

		public static void LoadElementDictionaryByPathForBR(Dictionary<int, ActionContainerElement> dictionary, CharacterBase owner, string path, bool isOtherPlayer)
		{
		}

		public ActionContainer(ActionContainerElement element, CharacterBase owner)
		{
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		public override void Reset()
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		public void PrepareDestroy()
		{
		}

		public override void Start()
		{
		}

		protected override void OnFinish()
		{
		}

		public override void Clear()
		{
		}

		public void OnMarkerClear(ChargeMarker marker, bool canRemove)
		{
		}

		public void ForceFinishState(int index)
		{
		}

		public void ForceClearMotionWait()
		{
		}

		public void SetConditionCheckResultForStartParam(int partIndex, bool value)
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		protected override bool OnFixedUpdate(float delta)
		{
			return default(bool);
		}

		private void RegisterActionParts(Gluon.ActionData.ActionParts[] elements, CharacterBase owner)
		{
		}

		private ActionParts RegisterActionParts(Gluon.ActionData.ActionParts element, int partsIndex, CharacterBase owner)
		{
			return null;
		}

		public void RegisterHitAttribute(ActionBase part, CollisionHitAttribute attr)
		{
		}

		public void RegisterTargetPosition(int id, Vector3 pos)
		{
		}

		private ActionParts CreateActionParts(Gluon.ActionData.ActionParts data_resource, long data_resource_id, CharacterBase owner)
		{
			return null;
		}

		public override void SetSkillId(int id)
		{
		}

		public override void SetSkillIndexForDmode(int index)
		{
		}

		public void SetTempoScale(float scale)
		{
		}

		public bool HasDamageHitAttribute(bool isIncludeDummy = false)
		{
			return default(bool);
		}

		public void ForceStopEffect(CharacterBase effectOwner, bool isAnimatableObjectOnly = false)
		{
		}

		public bool IsFinishedActionMove()
		{
			return default(bool);
		}

		public bool IsContainsFireStockBullet()
		{
			return default(bool);
		}

		private bool HaveActionPartsCommandTargetReticleUIOFF()
		{
			return default(bool);
		}

		public void AddDamageOnDamageCounterMode(int damage)
		{
		}

		public bool IsOnlyGuardCounter()
		{
			return default(bool);
		}

		public int GetServantNum()
		{
			return default(int);
		}

		public void SetAutoDelete(bool b)
		{
		}

		public void UpdateTargetTransform()
		{
		}

		public void SetOnHitCountAdded(Action<int> onHitCountAdded)
		{
		}

		public void ToggleHitCount(bool toOn)
		{
		}

		public void ToggleCriticalStatus(string dummyHitAttrLabel)
		{
		}

		public void SetActionCriticalStatus(CollisionHitAttribute.CriticalStatus criticalStatus)
		{
		}

		private void OnContainerHitCountAdded(int addHit)
		{
		}
	}
}

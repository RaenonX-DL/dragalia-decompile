using System;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SendSignalData : ActionParts.PartsData
	{
		[Serializable]
		public class ChangeParts
		{
			public string partsName;

			public bool enableCancel;

			public RenderPartsData.PartsNo setNo;

			public RenderPartsData.PartsNo cancelNo;
		}

		[Serializable]
		public class EnableAction
		{
			public AbilityTargetAction actionType;

			public bool isEnable;

			public bool isRemove;
		}

		[SerializeField]
		[HideInInspector]
		private CharacterBase.ActionSignal _signalType;

		[SerializeField]
		[HideInInspector]
		protected bool _motionEnd;

		[SerializeField]
		[HideInInspector]
		private int _actionId;

		[SerializeField]
		[HideInInspector]
		protected Gluon.ActionPartsActiveCancel.ActionType _actionType;

		[SerializeField]
		[HideInInspector]
		private DragonDecoration _decoId;

		[SerializeField]
		[HideInInspector]
		private bool _partsCancelInvincible;

		[SerializeField]
		[HideInInspector]
		private ChangeParts _changeParts;

		[SerializeField]
		[HideInInspector]
		private bool _keepActionEnd;

		[SerializeField]
		[HideInInspector]
		private int _keepActionId1;

		[SerializeField]
		[HideInInspector]
		private int _keepActionId2;

		[SerializeField]
		[HideInInspector]
		private bool _keepShareSkillOriginWeaponHide;

		[SerializeField]
		[HideInInspector]
		private CharacterBuffType _hitRecordTargetBuffType;

		[SerializeField]
		[HideInInspector]
		private EnableAction _enableAction;

		[SerializeField]
		[HideInInspector]
		private int _intArgs1;

		[SerializeField]
		[HideInInspector]
		private bool _boolArgs1;

		[SerializeField]
		[HideInInspector]
		private bool _boolArgs2;

		[SerializeField]
		[HideInInspector]
		private bool _boolArgs3;

		[SerializeField]
		[HideInInspector]
		private string _stringArgs1;

		[SerializeField]
		[HideInInspector]
		private float[] _damageCutRate;

		[SerializeField]
		[HideInInspector]
		private float[] _damageCutRateForGuardReaction;

		[SerializeField]
		[HideInInspector]
		private int _counterBAReactionMaxBreakLevel;

		[SerializeField]
		[HideInInspector]
		private int _counterAttachInvincibleLevel;

		[SerializeField]
		[HideInInspector]
		private int[] _actionIdForGuardReaction;

		public CharacterBase.ActionSignal signalType => default(CharacterBase.ActionSignal);

		public bool motionEnd => default(bool);

		public int actionId => default(int);

		public Gluon.ActionPartsActiveCancel.ActionType actionType => default(Gluon.ActionPartsActiveCancel.ActionType);

		public DragonDecoration decoId => default(DragonDecoration);

		public bool partsCancelInvincible => default(bool);

		public ChangeParts changeParts => null;

		public bool keepActionEnd => default(bool);

		public int keepActionId1 => default(int);

		public int keepActionId2 => default(int);

		public bool keepShareSkillOriginWeaponHide => default(bool);

		public CharacterBuffType hitRecordTargetBuffType => default(CharacterBuffType);

		public EnableAction enableAction => null;

		public int intArgs1 => default(int);

		public bool boolArgs1 => default(bool);

		public bool boolArgs2 => default(bool);

		public bool boolArgs3 => default(bool);

		public string stringArgs1 => null;

		public float[] damageCutRate => null;

		public float[] damageCutRateForGuardReaction => null;

		public int counterBAReactionMaxBreakLevel => default(int);

		public int counterAttachInvincibleLevel => default(int);

		public int[] actionIdForGuardReaction => null;
	}
}

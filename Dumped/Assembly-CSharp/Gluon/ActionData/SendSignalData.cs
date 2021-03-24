/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class SendSignalData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private CharacterBase.ActionSignal _signalType;
		[HideInInspector]
		[SerializeField]
		protected bool _motionEnd;
		[HideInInspector]
		[SerializeField]
		private int _actionId;
		[HideInInspector]
		[SerializeField]
		protected ActionPartsActiveCancel.ActionType _actionType;
		[HideInInspector]
		[SerializeField]
		private DragonDecoration _decoId;
		[HideInInspector]
		[SerializeField]
		private bool _partsCancelInvincible;
		[HideInInspector]
		[SerializeField]
		private ChangeParts _changeParts;
		[HideInInspector]
		[SerializeField]
		private bool _keepActionEnd;
		[HideInInspector]
		[SerializeField]
		private int _keepActionId1;
		[HideInInspector]
		[SerializeField]
		private int _keepActionId2;
		[HideInInspector]
		[SerializeField]
		private bool _keepShareSkillOriginWeaponHide;
		[HideInInspector]
		[SerializeField]
		private EnableAction _enableAction;
		[HideInInspector]
		[SerializeField]
		private int _intArgs1;
		[HideInInspector]
		[SerializeField]
		private bool _boolArgs1;
		[HideInInspector]
		[SerializeField]
		private bool _boolArgs2;
		[HideInInspector]
		[SerializeField]
		private bool _boolArgs3;
		[HideInInspector]
		[SerializeField]
		private string _stringArgs1;
		[HideInInspector]
		[SerializeField]
		private float[] _damageCutRate;
		[HideInInspector]
		[SerializeField]
		private float[] _damageCutRateForGuardReaction;
		[HideInInspector]
		[SerializeField]
		private int _counterBAReactionMaxBreakLevel;
		[HideInInspector]
		[SerializeField]
		private int _counterAttachInvincibleLevel;
		[HideInInspector]
		[SerializeField]
		private int[] _actionIdForGuardReaction;
	
		// Properties
		public CharacterBase.ActionSignal signalType { get; }
		public bool motionEnd { get; }
		public int actionId { get; }
		public ActionPartsActiveCancel.ActionType actionType { get; }
		public DragonDecoration decoId { get; }
		public bool partsCancelInvincible { get; }
		public ChangeParts changeParts { get; }
		public bool keepActionEnd { get; }
		public int keepActionId1 { get; }
		public int keepActionId2 { get; }
		public bool keepShareSkillOriginWeaponHide { get; }
		public EnableAction enableAction { get; }
		public int intArgs1 { get; }
		public bool boolArgs1 { get; }
		public bool boolArgs2 { get; }
		public bool boolArgs3 { get; }
		public string stringArgs1 { get; }
		public float[] damageCutRate { get; }
		public float[] damageCutRateForGuardReaction { get; }
		public int counterBAReactionMaxBreakLevel { get; }
		public int counterAttachInvincibleLevel { get; }
		public int[] actionIdForGuardReaction { get; }
	
		// Nested types
		[Serializable]
		public class ChangeParts
		{
			// Fields
			public string partsName;
			public bool enableCancel;
			public RenderPartsData.PartsNo setNo;
			public RenderPartsData.PartsNo cancelNo;
	
			// Constructors
			public ChangeParts();
		}
	
		[Serializable]
		public class EnableAction
		{
			// Fields
			public AbilityTargetAction actionType;
			public bool isEnable;
			public bool isRemove;
	
			// Constructors
			public EnableAction();
		}
	
		// Constructors
		public SendSignalData();
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public abstract class ActionParts : ActionBase
	{
		// Fields
		protected ActionContainer container;
		private float _originalStartTime;
		private float _originalDuration;
		[CompilerGenerated]
		private float _duration_k__BackingField;
		[CompilerGenerated]
		private float _tempoScale_k__BackingField;
		[CompilerGenerated]
		private int _activateId_k__BackingField;
		protected ActionData.ActionParts.PartsData.ConditionData conditionData;
		[CompilerGenerated]
		private ActionData.ActionParts.PartsData.LoopData _loopData_k__BackingField;
		private int loopCount;
		protected bool IsIgnoreFinishConditionOnUpdate;
	
		// Properties
		protected int actionId { get; }
		protected int productId { get; }
		protected int chargeLv { get; }
		public float duration { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public float endTime { get; }
		public float tempoScale { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int activateId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		protected ActionData.ActionParts.PartsData.LoopData loopData { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public abstract class PartsData
		{
			// Constructors
			protected PartsData();
		}
	
		// Constructors
		public ActionParts(ActionData.ActionParts resource);
	
		// Methods
		public virtual int[] GetActionIdsForLoad();
		public void RegisterParentActionContainer(ActionContainer container);
		public virtual void OnPostCreated(CharacterBase chara);
		public override void Initialize(CharacterBase chara);
		public override bool Update(float delta);
		protected bool CheckHitAttributeLabel(ref string label, bool useSameComponent, int overwriteSkillId = 0);
		protected override bool IsMatchExecuteCondition();
		public static bool CheckHitAttributeLabel(ref string label, CharacterBase owner, int actionId, int skillId, int chargeLv, bool useSameComponent);
		public static bool IsMatchHitAttirbuteShiftCondition(CharacterBase owner);
		public static ElementalType GetShareCharaElement(CharacterBase owner, int skillId);
		public static int GetShareCharaBaseId(HumanCharacter human, int skillId);
		public static bool IsShareSkill(CharacterBase owner, int skillId);
	}
}

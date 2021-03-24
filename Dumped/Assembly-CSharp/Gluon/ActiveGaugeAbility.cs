/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActiveGaugeAbility
	{
		// Fields
		private const int EFFECT_TRIGGER_OFFSET_1ST = 7;
		private const int EFFECT_TRIGGER_OFFSET_2ND = 12;
		private HumanCharacter _owner;
		private Param _param;
		private bool _isDirty;
		[CompilerGenerated]
		private AbilityGaugeMultiPlayService _MultiPlayService_k__BackingField;
	
		// Properties
		public AbilityGaugeMultiPlayService MultiPlayService { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isActive { get; }
	
		// Nested types
		public enum ActiveGaugeType
		{
			None = 0,
			Ranzal = 1
		}
	
		private class Param
		{
			// Fields
			protected const int PARAM_ELEMENT_NUM = 2;
			[CompilerGenerated]
			private AbilityDataElement _ade_k__BackingField;
			[CompilerGenerated]
			private int _adeIdx_k__BackingField;
			[CompilerGenerated]
			private AbilityTargetAction _targetAction_k__BackingField;
			[CompilerGenerated]
			private int _targetSkillLv_k__BackingField;
			public int curMaxGaugeNum;
			public int saveMaxGaugeNum;
			[CompilerGenerated]
			private int[] _gaugeValueList_k__BackingField;
			[CompilerGenerated]
			private int[] _accumulateEnhanceList_k__BackingField;
			[CompilerGenerated]
			private int[] _consumeEnhanceList_k__BackingField;
	
			// Properties
			public AbilityDataElement ade { [CompilerGenerated] get; [CompilerGenerated] protected set; }
			public int adeIdx { [CompilerGenerated] get; [CompilerGenerated] protected set; }
			public AbilityTargetAction targetAction { [CompilerGenerated] get; [CompilerGenerated] protected set; }
			public int targetSkillLv { [CompilerGenerated] get; [CompilerGenerated] protected set; }
			public int[] gaugeValueList { [CompilerGenerated] get; [CompilerGenerated] protected set; }
			public int[] accumulateEnhanceList { [CompilerGenerated] get; [CompilerGenerated] protected set; }
			public int[] consumeEnhanceList { [CompilerGenerated] get; [CompilerGenerated] protected set; }
			public virtual ActiveGaugeType type { get; }
	
			// Constructors
			public Param();
	
			// Methods
			public virtual bool Initialize(AbilityDataElement ade, int idx);
			public void AddGaugeValue(int idx, int val);
			public void SetGaugeValue(int idx, int val);
			public int GetGaugeValue(int idx);
			public int GetMaxGaugeNum();
			public virtual bool IsAllGaugeMax();
			public void ResetGaugeValue();
			public float GetAccumulateEnhanceRate(int idx);
			public float GetConsumeEnhanceRate(int idx);
			public void ClearGaugeValue();
		}
	
		private class ParamRanzal : Param
		{
			// Fields
			private const int GAUGE_NUM = 2;
	
			// Properties
			public override ActiveGaugeType type { get; }
	
			// Nested types
			public enum GaugeType
			{
				Normal = 0,
				Burst = 1
			}
	
			// Constructors
			public ParamRanzal();
	
			// Methods
			public override bool Initialize(AbilityDataElement ade, int idx);
			public override bool IsAllGaugeMax();
		}
	
		// Constructors
		public ActiveGaugeAbility();
	
		// Methods
		public void Initialize(CharacterBase original, CharacterBase current);
		public void Setup(CharacterBase owner, AbilityDataElement ade, int idx);
		public void OnHit(CollisionHitAttribute attr, PlayerActionElement action);
		public bool Update();
		private bool ApplyAccumulateEnhance(bool force = false);
		private void ApplyRanzal(int idx);
		public void ResetGaugeValue(int actionId);
		public float GetConsumeEnhanceRate(CollisionHitAttribute attr);
		public bool IsConsumeEnhanceTargetAction(int actionId);
		public void RestoreEffect();
		public int GetConsumeEnhanceEffectIdx();
		public int[] GetGaugeValueList();
		public void SetGaugeValueList(int[] gaugeValueList);
		public void ClearGaugeValue();
	}
}

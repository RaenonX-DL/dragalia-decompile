/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterCustomPointController
	{
		// Fields
		public static readonly int gaugeIndexMax;
		protected ObscuredInt[] cp;
		public float[] coef;
		[CompilerGenerated]
		private CharacterBase _owner_k__BackingField;
		[CompilerGenerated]
		private CollisionHitAttribute _hitAttributeSource_k__BackingField;
		protected List<AbilityDataElement> abilityList;
		public Type type;
	
		// Properties
		public virtual int minCP { get; }
		public virtual int maxCP { get; }
		public CharacterBase owner { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public CollisionHitAttribute hitAttributeSource { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Nested types
		public enum AbilityTriggerState
		{
			Disabled = 0,
			On = 1,
			Off = 2
		}
	
		public enum Type
		{
			None = 0,
			BP = 10150404,
			RKS = 10350102,
			SZ = 10750403,
			ZN = 10850402,
			IRA = 10950401
		}
	
		public enum IconType
		{
			None = 0,
			SZ = 1,
			RKS = 2,
			IRA = 3,
			ZN = 4,
			BP = 5
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public int charaId;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal bool _Create_b__0(ConditionallyAbility x);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<ConditionallyAbility, AbilityDataElement> __9__20_1;
			public static Func<AbilityDataElement, float> __9__24_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal AbilityDataElement _Create_b__20_1(ConditionallyAbility x);
			internal float _Initialize_b__24_0(AbilityDataElement x);
		}
	
		// Constructors
		public CharacterCustomPointController();
		static CharacterCustomPointController();
	
		// Methods
		public static CharacterCustomPointController Create(CharacterBase owner, List<ConditionallyAbility> conditionalAbilities, int charaId);
		private static CharacterCustomPointController Create(CharacterBase owner, Type type, params AbilityDataElement[] elems);
		public virtual void AttachToUI();
		public virtual int GetCP(int index);
		protected virtual void Initialize(CharacterBase owner, params AbilityDataElement[] elems);
		protected virtual void InitializeWithLength(int length);
		public virtual void ClearValues();
		public virtual void Update();
		public void SetModifyCPSource(CollisionHitAttribute attr);
		public virtual void SetCP(int index, int value);
		public void AddCP(int index, int value);
		protected virtual AbilityCondition GetUseConditionType(AbilityDataElement ade);
		protected virtual void TriggerAbility(AbilityDataElement ade, int actionId = 0, int skillId = 0, int skillIndex = 0);
		public virtual void OnSkill(int actionId, int skillId, int skillIndex);
		public virtual void OnContinue();
		public virtual IconType GetIconType();
		public virtual bool ClearCPOnContinue();
	}
}

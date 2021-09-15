/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterAuraCtrl
	{
		// Fields
		[CompilerGenerated]
		private List<Parameter> _auraList_k__BackingField;
		[CompilerGenerated]
		private bool _isDirty_k__BackingField;
		[CompilerGenerated]
		private float _elapsedSupportGameTime_k__BackingField;
	
		// Properties
		public List<Parameter> auraList { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isDirty { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float elapsedSupportGameTime { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public class Parameter
		{
			// Fields
			[CompilerGenerated]
			private int _multiPlayKey_k__BackingField;
			[CompilerGenerated]
			private int _auraId_k__BackingField;
			[CompilerGenerated]
			private AuraType _auraType_k__BackingField;
			[CompilerGenerated]
			private AuraConst.TargetType _targetType_k__BackingField;
			[CompilerGenerated]
			private int _level_k__BackingField;
			[CompilerGenerated]
			private float _rate_k__BackingField;
			[CompilerGenerated]
			private float _duration_k__BackingField;
			[CompilerGenerated]
			private float _initialDuration_k__BackingField;
			[CompilerGenerated]
			private CharacterBase _from_k__BackingField;
			[CompilerGenerated]
			private int _actionId_k__BackingField;
			[CompilerGenerated]
			private int _skillId_k__BackingField;
			[CompilerGenerated]
			private int _productId_k__BackingField;
			[CompilerGenerated]
			private int _publishLevel_k__BackingField;
			[CompilerGenerated]
			private Dictionary<int, int> _maxLimitLevelDict_k__BackingField;
			public const int defaultBaseAuraMaxLimitLevel = 2;
	
			// Properties
			public int multiPlayKey { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int auraId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public AuraType auraType { [CompilerGenerated] get; [CompilerGenerated] set; }
			public AuraConst.TargetType targetType { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int level { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float rate { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float duration { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float initialDuration { [CompilerGenerated] get; [CompilerGenerated] set; }
			public CharacterBase from { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int actionId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int skillId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int productId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int publishLevel { [CompilerGenerated] get; [CompilerGenerated] set; }
			public Dictionary<int, int> maxLimitLevelDict { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int maxLimitLevel { get; set; }
			public int levelForDisplay { get; }
			public int maxLimitLevelForDisplay { get; }
	
			// Constructors
			public Parameter();
	
			// Methods
			public bool LevelDown();
			public bool LevelUp(CharacterBase owner, PublishParam publishParam, int applyLimitLevel, out bool durationUpdate);
			public static void Publish(AuraDataElement elem, PublishParam publishParam, int maxLimitLevel);
		}
	
		public struct PublishParam
		{
			// Fields
			public CharacterBase from;
			public int actionId;
			public int skillId;
			public int productId;
	
			// Methods
			public void Setup(CharacterBase from, int actionId, int skillId, int productId);
		}
	
		// Constructors
		public CharacterAuraCtrl();
	
		// Methods
		public void OnPublished(CharacterBase owner, AuraDataElement elem, PublishParam publishParam, int maxLimitLevel);
		public void OnApplyByHitAttribute(CharacterBase owner, CollisionHitAttribute hitAttribute);
		private float GetDeltaTime(CharacterBase owner);
		public bool Update(CharacterBase owner);
		public void ResetDirty(CharacterBase owner);
		public void ResetAll(CharacterBase owner, RemoveBuffReason reason);
		public bool CheckValidEffect();
		public void Calculate(CharacterBase owner);
		public bool HasType(AuraType type, AuraConst.TargetType targetType);
		public int GetAuraLevelByType(AuraType type, AuraConst.TargetType targetType);
		public int GetAuraLevelSum(AuraConst.TargetType targetType);
		public Parameter FindAuraFromMultiPlayKey(int multiPlayKey);
	}
}

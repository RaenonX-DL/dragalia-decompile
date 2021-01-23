/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AbilityLimitCalculation
	{
		// Fields
		private List<AbilityDataElement> abilityDatas;
		[CompilerGenerated]
		private Dictionary<CategoryKeys, float> _limitedDict_k__BackingField;
	
		// Properties
		public Dictionary<CategoryKeys, float> limitedDict { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public class CategoryKeys
		{
			// Fields
			public int type;
			public int variousId;
			public AbilityTargetAction targetActionId;
			public AbilityCondition conditionId;
			public int limitedGroupId;
	
			// Constructors
			public CategoryKeys();
	
			// Methods
			public void Setup(int type, int variousId, AbilityTargetAction targetActionId = AbilityTargetAction.NONE, AbilityCondition conditionId = AbilityCondition.NONE, int limitedGroupId = 0);
		}
	
		private class CategoryComparer : IEqualityComparer<CategoryKeys>
		{
			// Constructors
			public CategoryComparer();
	
			// Methods
			public bool Equals(CategoryKeys a, CategoryKeys b);
			public int GetHashCode(CategoryKeys obj);
		}
	
		// Constructors
		public AbilityLimitCalculation();
	
		// Methods
		public void AddList(int id);
		public void AddList(AbilityDataElement ade);
		public void DecideLimited();
		private void AddDictionary(CategoryKeys keys, float value);
		private void AddDictionary(CategoryKeys keys, float value, AbilityTargetAction targetActionId);
		private void OverwriteLimit(CategoryKeys keys, float value);
		private void OverwriteLimit(CategoryKeys keys, float value, AbilityTargetAction targetActionId);
		public float ApplyLimit(CategoryKeys keys, float currentValue);
	}
}

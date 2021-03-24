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
	public class UniqueComboData
	{
		// Fields
		[CompilerGenerated]
		private int _id_k__BackingField;
		[CompilerGenerated]
		private int _actionId_k__BackingField;
		[CompilerGenerated]
		private int _exActionId_k__BackingField;
		[CompilerGenerated]
		private int _maxComboNum_k__BackingField;
		[CompilerGenerated]
		private ShiftConditionType _shiftCondition_k__BackingField;
		[CompilerGenerated]
		private int _conditionArgsI1_k__BackingField;
		[CompilerGenerated]
		private string _buffHitAttr_k__BackingField;
	
		// Properties
		public int id { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int actionId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int exActionId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int maxComboNum { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ShiftConditionType shiftCondition { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int conditionArgsI1 { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string buffHitAttr { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum ShiftConditionType
		{
			None = 0,
			HitNum = 1,
			Buff = 2
		}
	
		// Constructors
		public UniqueComboData(CharaUniqueComboElement data);
	
		// Methods
		public void Reset(CharacterBase owner);
		public void ResetFromBuff(CharacterBase owner);
		public bool IsEnableShiftCondition(CharacterBase owner);
	}
}

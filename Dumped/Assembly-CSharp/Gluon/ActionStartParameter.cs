/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon.Gimmick;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionStartParameter
	{
		// Fields
		[CompilerGenerated]
		private int _totalDamageOnDamageCounterMode_k__BackingField;
		[CompilerGenerated]
		private float _skillDamageUpBuffRate_k__BackingField;
		[CompilerGenerated]
		private float _additionalDamageOnHpConsumption_k__BackingField;
		public float[] cpCoef;
		[CompilerGenerated]
		private WarpRoom.RoomGroup _warpRoomGroupId_k__BackingField;
		[CompilerGenerated]
		private int _hitCount_k__BackingField;
		[CompilerGenerated]
		private int _buffCount_k__BackingField;
		[CompilerGenerated]
		private Dictionary<int, int> _specificBuffCounts_k__BackingField;
		[CompilerGenerated]
		private int _tensionLevel_k__BackingField;
		[CompilerGenerated]
		private int _inspirationLevel_k__BackingField;
		[CompilerGenerated]
		private Dictionary<int, bool> _conditionCheckResults_k__BackingField;
		[CompilerGenerated]
		private BurstDamageUpData _burstDamageUpData_k__BackingField;
	
		// Properties
		public int totalDamageOnDamageCounterMode { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float skillDamageUpBuffRate { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float additionalDamageOnHpConsumption { [CompilerGenerated] get; [CompilerGenerated] set; }
		public WarpRoom.RoomGroup warpRoomGroupId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int hitCount { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int buffCount { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Dictionary<int, int> specificBuffCounts { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int tensionLevel { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int inspirationLevel { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Dictionary<int, bool> conditionCheckResults { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public BurstDamageUpData burstDamageUpData { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public class BurstDamageUpData
		{
			// Fields
			[CompilerGenerated]
			private float _total_k__BackingField;
			[CompilerGenerated]
			private float _buff_k__BackingField;
			[CompilerGenerated]
			private float _aura_k__BackingField;
			[CompilerGenerated]
			private float _other_k__BackingField;
			[CompilerGenerated]
			private float _down_k__BackingField;
			[CompilerGenerated]
			private int _fireCount_k__BackingField;
	
			// Properties
			public float total { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float buff { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float aura { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float other { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float down { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int fireCount { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public BurstDamageUpData();
	
			// Methods
			public void Clear();
			public void SetUp(float buff, float aura, float other, float down);
			public void SetTotalForcibly(float total);
			private void CalcTotal();
		}
	
		// Constructors
		public ActionStartParameter();
	
		// Methods
		public void Clear();
		public void Clone(ActionStartParameter src);
	}
}

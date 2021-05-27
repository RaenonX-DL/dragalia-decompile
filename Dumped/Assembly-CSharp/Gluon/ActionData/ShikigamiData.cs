/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class ShikigamiData : StockBulletData
	{
		// Fields
		public const int autoFireActionsAlloc = 18;
		[HideInInspector]
		[SerializeField]
		private int[] _autoFireActionIdList;
		[HideInInspector]
		[SerializeField]
		private int _effectTriggerLv2;
		[HideInInspector]
		[SerializeField]
		private int _autoFireEffectTriggerLv2;
		[HideInInspector]
		[SerializeField]
		private int _cpCostOnAttack;
		[HideInInspector]
		[SerializeField]
		private int _cpCostOnAttackLv2;
		[HideInInspector]
		[SerializeField]
		private int _hitCountForLevelUp;
		[HideInInspector]
		[SerializeField]
		private int _actionConditionId;
		[HideInInspector]
		[SerializeField]
		private int _fireTrigger;
		[HideInInspector]
		[SerializeField]
		private string _headTextSummon;
		[HideInInspector]
		[SerializeField]
		private int _headIconSummon;
		[HideInInspector]
		[SerializeField]
		private string _headTextLvUp;
		[HideInInspector]
		[SerializeField]
		private int _headIconLvUp;
	
		// Properties
		public int[] autoFireActionIdList { get; }
		public int effectTriggerLv2 { get; }
		public int autoFireEffectTriggerLv2 { get; }
		public int cpCostOnAttack { get; }
		public int cpCostOnAttackLv2 { get; }
		public int hitCountForLevelUp { get; }
		public int actionConditionId { get; }
		public int fireTrigger { get; }
		public string headTextSummon { get; }
		public int headIconSummon { get; }
		public string headTextLvUp { get; }
		public int headIconLvUp { get; }
	
		// Nested types
		public enum QuantityIndex
		{
			Single = 0,
			Double = 1,
			Triple = 2,
			Max = 3
		}
	
		public enum PositionIndex
		{
			First = 0,
			Second = 1,
			Thrid = 2,
			Max = 3
		}
	
		public enum LevelIndex
		{
			One = 0,
			Two = 1,
			Max = 2
		}
	
		// Constructors
		public ShikigamiData();
	
		// Methods
		public static int GetAutoFireActionIndex(QuantityIndex q, PositionIndex p, LevelIndex l);
	}
}

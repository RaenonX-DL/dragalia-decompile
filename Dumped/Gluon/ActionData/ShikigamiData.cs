using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ShikigamiData : StockBulletData
	{
		public enum QuantityIndex
		{
			Single,
			Double,
			Triple,
			Max
		}

		public enum PositionIndex
		{
			First,
			Second,
			Thrid,
			Max
		}

		public enum LevelIndex
		{
			One,
			Two,
			Max
		}

		public const int autoFireActionsAlloc = 18;

		[SerializeField]
		[HideInInspector]
		private int[] _autoFireActionIdList;

		[SerializeField]
		[HideInInspector]
		private int _effectTriggerLv2;

		[SerializeField]
		[HideInInspector]
		private int _autoFireEffectTriggerLv2;

		[SerializeField]
		[HideInInspector]
		private int _cpCostOnAttack;

		[SerializeField]
		[HideInInspector]
		private int _cpCostOnAttackLv2;

		[SerializeField]
		[HideInInspector]
		private int _hitCountForLevelUp;

		[SerializeField]
		[HideInInspector]
		private int _actionConditionId;

		[SerializeField]
		[HideInInspector]
		private int _fireTrigger;

		[SerializeField]
		[HideInInspector]
		private string _headTextSummon;

		[SerializeField]
		[HideInInspector]
		private int _headIconSummon;

		[SerializeField]
		[HideInInspector]
		private string _headTextLvUp;

		[SerializeField]
		[HideInInspector]
		private int _headIconLvUp;

		public int[] autoFireActionIdList => null;

		public int effectTriggerLv2 => default(int);

		public int autoFireEffectTriggerLv2 => default(int);

		public int cpCostOnAttack => default(int);

		public int cpCostOnAttackLv2 => default(int);

		public int hitCountForLevelUp => default(int);

		public int actionConditionId => default(int);

		public int fireTrigger => default(int);

		public string headTextSummon => null;

		public int headIconSummon => default(int);

		public string headTextLvUp => null;

		public int headIconLvUp => default(int);

		public static int GetAutoFireActionIndex(QuantityIndex q, PositionIndex p, LevelIndex l)
		{
			return default(int);
		}
	}
}

using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class UniqueComboData
	{
		public enum ShiftConditionType
		{
			None,
			HitNum,
			Buff
		}

		public int id
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int actionId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int exActionId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int maxComboNum
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ShiftConditionType shiftCondition
		{
			[CompilerGenerated]
			get
			{
				return default(ShiftConditionType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int conditionArgsI1
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string buffHitAttr
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public UniqueComboData(CharaUniqueComboElement data)
		{
		}

		public void Reset(CharacterBase owner)
		{
		}

		public void ResetFromBuff(CharacterBase owner)
		{
		}

		public bool IsEnableShiftCondition(CharacterBase owner)
		{
			return default(bool);
		}
	}
}

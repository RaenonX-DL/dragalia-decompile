using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(0, Size = 8)]
	public struct ApplyAbnormalStatusResult
	{
		public enum Types
		{
			Unchanged,
			Affected,
			Registed,
			Cleared
		}

		private static readonly int UnchangedValue;

		private static readonly int ResistNormalValue;

		private static readonly int ResistPerfectValue;

		private static readonly int ResistHiddenValue;

		private static readonly int ClearedValue;

		private int _value;

		private bool _isDelayAffect;

		public static readonly ApplyAbnormalStatusResult Unchanged;

		public static readonly ApplyAbnormalStatusResult Cleared;

		public int ConditionId => default(int);

		public Types Type => default(Types);

		public ApplyAbnormalStatusResult(int conditionId, bool isDelayAffect = false)
		{
		}

		public static ApplyAbnormalStatusResult FromResist(bool isPerfect, bool isShow)
		{
			return default(ApplyAbnormalStatusResult);
		}

		public void Clear()
		{
		}

		public bool IsPerfectResist()
		{
			return default(bool);
		}

		public bool IsShowResist()
		{
			return default(bool);
		}

		public bool IsDelayAffect()
		{
			return default(bool);
		}

		public static int Serialize(ApplyAbnormalStatusResult result)
		{
			return default(int);
		}

		public static ApplyAbnormalStatusResult Deserialize(int value)
		{
			return default(ApplyAbnormalStatusResult);
		}
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public struct ApplyAbnormalStatusResult
	{
		// Fields
		private static readonly int UnchangedValue;
		private static readonly int ResistNormalValue;
		private static readonly int ResistPerfectValue;
		private static readonly int ResistHiddenValue;
		private static readonly int ClearedValue;
		private int _value;
		private bool _isDelayAffect;
		public static readonly ApplyAbnormalStatusResult Unchanged;
		public static readonly ApplyAbnormalStatusResult Cleared;
	
		// Properties
		public int ConditionId { get; }
		public Types Type { get; }
	
		// Nested types
		public enum Types
		{
			Unchanged = 0,
			Affected = 1,
			Registed = 2,
			Cleared = 3
		}
	
		// Constructors
		public ApplyAbnormalStatusResult(int conditionId, bool isDelayAffect = false);
		static ApplyAbnormalStatusResult();
	
		// Methods
		public static ApplyAbnormalStatusResult FromResist(bool isPerfect, bool isShow);
		public void Clear();
		public bool IsPerfectResist();
		public bool IsShowResist();
		public bool IsDelayAffect();
		public static int Serialize(ApplyAbnormalStatusResult result);
		public static ApplyAbnormalStatusResult Deserialize(int value);
	}
}

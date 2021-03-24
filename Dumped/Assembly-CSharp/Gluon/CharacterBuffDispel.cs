/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class CharacterBuffDispel
	{
		// Fields
		public const int DispelEfficacyType = 100;
		private static bool _tmpHasDispel;
	
		// Nested types
		public struct PriorityData
		{
			// Fields
			public int baseValue;
			public float sec;
	
			// Methods
			public static PriorityData Lowest();
			public static bool operator <(PriorityData a, PriorityData b);
			public static bool operator >(PriorityData a, PriorityData b);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<CollisionHitAttribute, int> __9__4_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _IsDispelHitAttribute_b__4_0(CollisionHitAttribute hitAttr_, int actionConditionId);
		}
	
		// Constructors
		static CharacterBuffDispel();
	
		// Methods
		public static PriorityData GetDispelPriority(ref CharacterBuff.BuffUnion buff);
		public static bool IsDispelHitAttribute(CollisionHitAttribute hitAttr);
		public static bool IsDispelActionCondition(int actionConditionId);
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactModel
	{
		// Fields
		private static ContactModel instance;
		public const int reliabilityMaxLevel = 30;
		public int selectedDragonMasterId;
		public bool isInit;
		public int pettingDragonMasterId;
	
		// Properties
		public static ContactModel Instance { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<DragonReliabilityList, bool> __9__12_0;
			public static Func<DragonReliabilityList, int> __9__12_1;
			public static Func<DragonReliabilityList, int> __9__12_2;
			public static Func<DragonList, int> __9__14_0;
			public static Func<DragonList, int> __9__14_4;
			public static Func<DragonList, ulong> __9__14_5;
			public static Func<IGrouping<int, DragonList>, IOrderedEnumerable<DragonList>> __9__14_1;
			public static Func<IOrderedEnumerable<DragonList>, DragonList> __9__14_2;
			public static Func<DragonList, ulong> __9__14_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _GetRecentPettedDragonList_b__12_0(DragonReliabilityList x);
			internal int _GetRecentPettedDragonList_b__12_1(DragonReliabilityList x);
			internal int _GetRecentPettedDragonList_b__12_2(DragonReliabilityList x);
			internal int _GetAllDragonByTypeKeyIdList_b__14_0(DragonList item);
			internal IOrderedEnumerable<DragonList> _GetAllDragonByTypeKeyIdList_b__14_1(IGrouping<int, DragonList> group);
			internal int _GetAllDragonByTypeKeyIdList_b__14_4(DragonList x);
			internal ulong _GetAllDragonByTypeKeyIdList_b__14_5(DragonList x);
			internal DragonList _GetAllDragonByTypeKeyIdList_b__14_2(IOrderedEnumerable<DragonList> x);
			internal ulong _GetAllDragonByTypeKeyIdList_b__14_3(DragonList x);
		}
	
		// Constructors
		private ContactModel();
		static ContactModel();
	
		// Methods
		public static void DeleteInstance();
		public static List<int> GetAvailablePettingList();
		public static List<DragonReliabilityList> GetAvailableReliabilityList();
		public static List<int> GetRecentPettedDragonList(int maxCount = 5);
		public static int GetRatestPettedDragonID();
		public List<ulong> GetAllDragonByTypeKeyIdList();
		public static int GetDragonReliabilityLevel(int dragonId);
		public static int GetDragonReliabilityTotalExp(int dragonId);
		public int GetDragonReliabilityLevel();
		public int GetDragonReliabilityTotalExp();
		public bool IsWalkerUnit();
		public static bool IsHideDragon(int dragonId);
	}
}

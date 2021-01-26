/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonResultData
	{
		// Fields
		public List<SummonResultItemData> items;
		public List<SummonResultPrize> summonResultPrizeList;
		public bool hasAutoPresentBoxItems;
		public SummonResultExchangeData summonPointData;
		public int tutorialSummonItemStartIndex;
		public readonly int tutorialSummonCurItemCount;
		public int tutorialSummonCurItemMaxCount;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<SummonResultItemData> __9__6_0;
			public static Comparison<SummonResultItemData> __9__13_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _UpdateDataFromResponse_b__6_0(SummonResultItemData a, SummonResultItemData b);
			internal int _UpdateBoxSummonResultData_b__13_0(SummonResultItemData a, SummonResultItemData b);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public AtgenBoxSummonResult result;
			public int i;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal bool _ParseBoxSummonData_b__0(AtgenBoxSummonDetail a);
			internal bool _ParseBoxSummonData_b__1(AtgenBoxSummonDetail a);
			internal bool _ParseBoxSummonData_b__2(AtgenBoxSummonDetail a);
		}
	
		// Constructors
		public SummonResultData();
	
		// Methods
		public void UpdateDataFromTutorial(int id);
		public void UpdateDataFromResponse();
		public void UpdateDataFromResponse(AtgenBoxSummonResult result, int startIndex, int itemCount);
		public void TutorialSummonReset();
		public bool hasNextItems();
		public void UpdateDataFromTutorialSummonResponse(UserRedoableSummonData result);
		public void UpdateBoxSummonResultData(AtgenBoxSummonResult result, int startIndex, int itemCount);
		private void ParseBoxSummonData(AtgenBoxSummonResult result, int i, ref Rarity maxViewRarity, bool addToItems = true);
	}
}

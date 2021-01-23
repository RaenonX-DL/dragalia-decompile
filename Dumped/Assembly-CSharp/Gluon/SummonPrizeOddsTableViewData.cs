/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonPrizeOddsTableViewData
	{
		// Fields
		public int rank;
		public string rate;
		public GiftType giftType;
		public int id;
		public int quantity;
		public string displayName;
		public bool title;
		public bool caption;
	
		// Constructors
		public SummonPrizeOddsTableViewData();
		public SummonPrizeOddsTableViewData(AtgenSummonPrizeEntitySetList entityInfo, AtgenBuildEventRewardEntityList entityItem);
	
		// Methods
		public void SetCaption(AtgenSummonPrizeRankList entityInfo);
		public void SetTitle();
		public static string GetRankName(int rank);
	}
}

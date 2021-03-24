/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MenuSummonHistoryCellData
	{
		// Fields
		public string unitName;
		public string summonDateTime;
		public string summonName;
		public SummonType summonType;
		public SummonPaymentType summonPaymentType;
		public Rarity summonRarity;
		public int summonDewPoint;
		public int summonPrizePoint;
		public GiftType summonGiftType;
		public int summonPoint;
	
		// Nested types
		public enum SummonType
		{
			SummonMulti = 0,
			SummonSingle = 1,
			SummonOnceaDay = 2,
			SummonFreeSingle = 3,
			SummonFreeMulti = 4,
			SummonBeginnerCampaign = 5
		}
	
		public enum SummonPaymentType
		{
			None = 0,
			Diamond = 1,
			Crystal = 2,
			SummonTicket = 3,
			SummonTicketTen = 4,
			CharaSsrTicket = 5,
			DragonSsrTicket = 6
		}
	
		// Constructors
		public MenuSummonHistoryCellData();
	
		// Methods
		public void Load(SummonHistoryList data);
		private string GetSummonUnitName(SummonHistoryList data);
		private string GetSummonTitle(SummonHistoryList data);
		private SummonType GetSummonType(SummonHistoryList data);
		private SummonPaymentType GetSummonPaymentType(SummonHistoryList data);
		private string UnixTimeToStringLongSpace(double unixtime);
	}
}

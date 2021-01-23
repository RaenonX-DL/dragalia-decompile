/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public abstract class SummonModelBase
	{
		// Fields
		[CompilerGenerated]
		private SummonResultData _resultData_k__BackingField;
	
		// Properties
		public abstract int singlePrice { get; }
		public abstract int multiPrice { get; }
		public SummonResultData resultData { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public class HoldingSummonTicketInfo
		{
			// Fields
			public SummonType summonType;
			public int drawType;
			public int totalCount;
			public List<int> ticketIdList;
			public const int singleDrawType = 1;
			public const int multiDrawType = 2;
	
			// Constructors
			public HoldingSummonTicketInfo();
		}
	
		// Constructors
		protected SummonModelBase();
	
		// Methods
		public abstract bool CanReSummon();
		public abstract int GetTicketCount(bool multi);
		public abstract bool IsSingle();
		public static List<HoldingSummonTicketInfo> GetHoldingSummonTicketInfo();
		public static string GetItemName(GiftType giftType, int itemId, bool isMoon, int specificQuantity = 0, int two_step_id = 0);
		public static void SetItemIconSprite(Image image, GiftType giftType, int itemId, int twoStepId, IconLoader.Size size);
		private static void SetItemIconSpriteForTwoStep(Image image, int itemId, int twoStepId, IconLoader.Size size);
	}
}

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace Gluon
{
	public abstract class SummonModelBase
	{
		public class HoldingSummonTicketInfo
		{
			public SummonType summonType;

			public int drawType;

			public int totalCount;

			public List<int> ticketIdList;

			public const int singleDrawType = 1;

			public const int multiDrawType = 2;
		}

		public abstract int singlePrice { get; }

		public abstract int multiPrice { get; }

		public SummonResultData resultData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public abstract bool CanReSummon();

		public abstract int GetTicketCount(bool multi);

		public abstract bool IsSingle();

		public static List<HoldingSummonTicketInfo> GetHoldingSummonTicketInfo()
		{
			return null;
		}

		public static string GetItemName(GiftType giftType, int itemId, bool isMoon, int specificQuantity = 0, int two_step_id = 0)
		{
			return null;
		}

		public static void SetItemIconSprite(Image image, GiftType giftType, int itemId, int twoStepId, IconLoader.Size size)
		{
		}

		private static void SetItemIconSpriteForTwoStep(Image image, int itemId, int twoStepId, IconLoader.Size size)
		{
		}
	}
}

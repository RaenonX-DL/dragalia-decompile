using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class ShopTradeCharaTalkSelector : OutGameTopCharaTalkSelector
	{
		public static Queue<int> myLastPlayedQueue;

		private bool isInitialSelectDone;

		private TalkData specialPackTalkData;

		private TalkData dailyMaterialTalkData;

		private TalkData weeklyMaterialTalkData;

		private TalkData monthlyMaterialTalkData;

		private TalkData expendableTalkData;

		private TalkData tradeTalkData;

		public int activeMenuGroupId
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

		public int activeImageId
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

		public static void ClearLastPlayedQueue()
		{
		}

		public TalkData SelectTalk(ShopCommonPage.TalkTypeInfo info)
		{
			return null;
		}

		public override void Awake()
		{
		}

		protected override TalkData SelectFromSpecialList()
		{
			return null;
		}
	}
}

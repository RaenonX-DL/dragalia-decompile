using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class PushMessageHolderModel
	{
		private static PushMessageHolderModel instance;

		public List<PushNoticeData> pushMessageList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static PushMessageHolderModel Instance => null;

		public static void DeleteInstance()
		{
		}

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		public void Init()
		{
		}

		private void AddMessage(int id, string message)
		{
		}

		public bool isLoadGuildScene()
		{
			return default(bool);
		}

		private PushMessageHolderModel()
		{
		}

		static PushMessageHolderModel()
		{
		}
	}
}

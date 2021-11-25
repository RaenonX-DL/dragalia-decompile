using System.Runtime.InteropServices;
using Gluon.Dungeon;

namespace Gluon
{
	public class NotifyDungeonObject
	{
		public enum NoticeType
		{
			TargetObject,
			Death
		}

		public delegate void NotifyDelegate(DungeonObjectBase sender, NoticeType notice, object param);

		private static int numNotice;

		private NotifyDelegate[] notifyDelegates;

		private static int GetNoticeNum()
		{
			return default(int);
		}

		public void Attach(NoticeType notice, NotifyDelegate func)
		{
		}

		public void Detach(NoticeType notice, NotifyDelegate func)
		{
		}

		public void Detach(NotifyDelegate func)
		{
		}

		public void Detach()
		{
		}

		public void Notify(DungeonObjectBase sender, NoticeType notice, [Optional] object param)
		{
		}
	}
}

using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public class DmodeTalkDataModel
	{
		public enum DmodeTalkTopCategory0
		{
			Top = 1
		}

		public enum DmodeTalkTopCategory1
		{
			Versatility = 1
		}

		private static DmodeTalkDataModel instance;

		public Dictionary<string, List<EventQuestTalkDataModel.TalkSet>> availableTalkCharaSetDic;

		private int currentPlayingId;

		public List<string> preferredCharaList;

		public static DmodeTalkDataModel Instance => null;

		public static void DeleteInstance()
		{
		}

		public static bool IsInstanceNull()
		{
			return default(bool);
		}

		private DmodeTalkDataModel()
		{
		}

		static DmodeTalkDataModel()
		{
		}

		public void Clear()
		{
		}

		public EventQuestTalkDataModel.TalkSet GetAvailableTalk()
		{
			return null;
		}

		public void GatherAvailableTalks()
		{
		}

		private EventQuestTalkDataModel.TalkSet WrapDmodeTalk(DmodeTalkElement item)
		{
			return null;
		}

		public EventQuestTalkDataModel.TalkSet GetCurrentPlayingTalk()
		{
			return null;
		}
	}
}

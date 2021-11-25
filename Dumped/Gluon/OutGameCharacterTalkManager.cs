using System.Collections.Generic;

namespace Gluon
{
	public class OutGameCharacterTalkManager : SingletonInBaseMonoBehaviour<OutGameCharacterTalkManager>
	{
		public class TalkEntity
		{
			public string talkText;

			public string voiceId;

			public string voiceGroup;
		}

		private class Talks
		{
			public Dictionary<int, TalkEntity> talks;

			public void Init()
			{
			}

			public void AddText(int index, string text, int charaId, int baseVoiceId)
			{
			}
		}

		private class TalkListDict
		{
			public Dictionary<int, Talks> dict;

			public void Init()
			{
			}

			public void AddText(int charaId, int index, string text, int baseVoiceId)
			{
			}

			public TalkEntity GetTalk(int charaId, int index)
			{
				return null;
			}

			public int GetTextCount(int charaId)
			{
				return default(int);
			}
		}

		private TalkListDict greetingTalkDict;

		private TalkListDict tweetTalkDict;

		private TalkListDict bigTalkDict;

		private TalkListDict greetingSpecialTalkDict;

		private TalkListDict tweetSpecialTalkDict;

		private TalkListDict bigSpecialTalkDict;

		private bool isTalkInitialized;

		protected override void Awake()
		{
		}

		public void InitTalkData()
		{
		}

		public int GetGreetingTalkCount(int charaId, bool isPrologue)
		{
			return default(int);
		}

		public int GetTweetTalkCount(int charaId, bool isPrologue)
		{
			return default(int);
		}

		public int GetBigTalkCount(int charaId, bool isPrologue)
		{
			return default(int);
		}

		public TalkEntity GetGreetingTalk(int charaId, int index, bool isPrologue)
		{
			return null;
		}

		public TalkEntity GetTweetTalk(int charaId, int index, bool isPrologue)
		{
			return null;
		}

		public TalkEntity GetBigTalk(int charaId, int index, bool isPrologue)
		{
			return null;
		}

		public static bool isNoTalkCharactor(int charaId)
		{
			return default(bool);
		}
	}
}

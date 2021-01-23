/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OutGameCharacterTalkManager : SingletonInBaseMonoBehaviour<Gluon.OutGameCharacterTalkManager>
	{
		// Fields
		private TalkListDict greetingTalkDict;
		private TalkListDict tweetTalkDict;
		private TalkListDict bigTalkDict;
		private TalkListDict greetingSpecialTalkDict;
		private TalkListDict tweetSpecialTalkDict;
		private TalkListDict bigSpecialTalkDict;
		private bool isTalkInitialized;
	
		// Nested types
		public class TalkEntity
		{
			// Fields
			public string talkText;
			public string voiceId;
			public string voiceGroup;
	
			// Constructors
			public TalkEntity();
		}
	
		private class Talks
		{
			// Fields
			public Dictionary<int, TalkEntity> talks;
	
			// Constructors
			public Talks();
	
			// Methods
			public void Init();
			public void AddText(int index, string text, int charaId, int baseVoiceId);
		}
	
		private class TalkListDict
		{
			// Fields
			public Dictionary<int, Talks> dict;
	
			// Constructors
			public TalkListDict();
	
			// Methods
			public void Init();
			public void AddText(int charaId, int index, string text, int baseVoiceId);
			public TalkEntity GetTalk(int charaId, int index);
			public int GetTextCount(int charaId);
		}
	
		// Constructors
		public OutGameCharacterTalkManager();
	
		// Methods
		protected override void Awake();
		public void InitTalkData();
		public int GetGreetingTalkCount(int charaId, bool isPrologue);
		public int GetTweetTalkCount(int charaId, bool isPrologue);
		public int GetBigTalkCount(int charaId, bool isPrologue);
		public TalkEntity GetGreetingTalk(int charaId, int index, bool isPrologue);
		public TalkEntity GetTweetTalk(int charaId, int index, bool isPrologue);
		public TalkEntity GetBigTalk(int charaId, int index, bool isPrologue);
		public static bool isNoTalkCharactor(int charaId);
	}
}

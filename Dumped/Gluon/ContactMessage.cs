using System.Runtime.CompilerServices;

namespace Gluon
{
	public static class ContactMessage
	{
		public enum ContactEmotion
		{
			Joy,
			Happy,
			Hate,
			MAX
		}

		private enum Category0
		{
			DragonContact = 1
		}

		private enum Category1
		{
			Greeting = 1,
			Joy,
			Hate,
			Present,
			Levelup,
			Free0,
			Free1,
			Free2
		}

		public class ContactMessageData
		{
			public string message
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

			public string voice
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

			public ContactEmotion emotion
			{
				[CompilerGenerated]
				get
				{
					return default(ContactEmotion);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public ContactMessageData(string a_message, string a_voice, ContactEmotion a_emotion = ContactEmotion.MAX)
			{
			}
		}

		private const string DragonOutVoiceNameFormat = "VO_DRG_{0}_OUT_{1:D4}";

		public static string GetDragonBaseID(int dragonID)
		{
			return null;
		}

		public static string GetDragonVoiceName(int dragonID, int voiceNumber)
		{
			return null;
		}

		public static string GetDragonVoiceGroup(int dragonID)
		{
			return null;
		}

		public static string GetDragonStoryVoiceGroup(int dragonID)
		{
			return null;
		}

		public static ContactMessageData GetGreetingMessage(int dragonID)
		{
			return null;
		}

		public static ContactMessageData GetContactMessage(int dragonID)
		{
			return null;
		}

		public static ContactMessageData GetPresentMessage(int dragonID)
		{
			return null;
		}

		public static ContactMessageData GetFriendlyLevelupMessage(int dragonID)
		{
			return null;
		}

		public static ContactMessageData GetHateMessage(int dragonID)
		{
			return null;
		}

		public static ContactMessageData GetRandomMessage(int dragonID, int friendlyLevel)
		{
			return null;
		}
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class ContactMessage
	{
		// Fields
		private const string DragonOutVoiceNameFormat = "VO_DRG_{0}_OUT_{1:D4}";
	
		// Nested types
		public enum ContactEmotion
		{
			Joy = 0,
			Happy = 1,
			Hate = 2,
			MAX = 3
		}
	
		private enum Category0
		{
			DragonContact = 1
		}
	
		private enum Category1
		{
			Greeting = 1,
			Joy = 2,
			Hate = 3,
			Present = 4,
			Levelup = 5,
			Free0 = 6,
			Free1 = 7,
			Free2 = 8
		}
	
		public class ContactMessageData
		{
			// Fields
			[CompilerGenerated]
			private string _message_k__BackingField;
			[CompilerGenerated]
			private string _voice_k__BackingField;
			[CompilerGenerated]
			private ContactEmotion _emotion_k__BackingField;
	
			// Properties
			public string message { [CompilerGenerated] get; [CompilerGenerated] set; }
			public string voice { [CompilerGenerated] get; [CompilerGenerated] set; }
			public ContactEmotion emotion { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public ContactMessageData(string a_message, string a_voice, ContactEmotion a_emotion = ContactEmotion.MAX);
		}
	
		// Methods
		public static string GetDragonBaseID(int dragonID);
		public static string GetDragonVoiceName(int dragonID, int voiceNumber);
		public static string GetDragonVoiceGroup(int dragonID);
		public static string GetDragonStoryVoiceGroup(int dragonID);
		public static ContactMessageData GetGreetingMessage(int dragonID);
		public static ContactMessageData GetContactMessage(int dragonID);
		public static ContactMessageData GetPresentMessage(int dragonID);
		public static ContactMessageData GetFriendlyLevelupMessage(int dragonID);
		public static ContactMessageData GetHateMessage(int dragonID);
		public static ContactMessageData GetRandomMessage(int dragonID, int friendlyLevel);
	}
}

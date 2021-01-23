/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class WalkerUtil
	{
		// Fields
		private const string questCharacterPrefKey = "Walker.questCharacterPrefKey";
		private const int WalkerEventId = 31002;
		private const int WalkerCharaId = 19900004;
		public const int PresentItemReliability = 200;
		public static int extraInformationId;
		public const string MyPageWalkerVoicesGroup = "VO_CHR_210128_01_MYPAGE";
		private const int prologueInfoId = 1099;
		private const int epilogueInfoId = 1100;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public Action continueAction;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _WalkerGetEventData_b__0();
		}
	
		// Constructors
		public WalkerUtil();
		static WalkerUtil();
	
		// Methods
		public static bool IsWalkerEventId(int eventId);
		public static bool IsNeedToAddQuestList();
		public static bool IsWalkerEventDay();
		public static bool IsWalkerEventWaitForClose();
		public static bool IsWalkerEvent();
		public static string GetPreloadUrl(string defaultUrl);
		public static bool IsNeedToGoWalker();
		public static bool IsWalkerQuest(int questId);
		public static bool IsPlayingWalkerQuest();
		public static void SetWalkerQuestParty();
		public static void SaveWalkerQuestParty();
		public static void WalkerGetEventData(Action continueAction);
		public static List<SimpleEventItemElement> GetWalkerEventItemList();
		public static int GetSimpleEventItemCount(int num);
		public static bool IsWalkerChara(CharacterBase chara);
		public static bool IsWalkerChara(int charaId);
	}
}

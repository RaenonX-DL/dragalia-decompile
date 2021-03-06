﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventQuestTalkDataModel
	{
		// Fields
		private static EventQuestTalkDataModel instance;
		public Dictionary<string, List<TalkSet>> availableTalkCharaSetDic;
		private int currentPlayingId;
		public List<string> preferredCharaList;
		public List<int> enableMiniCharaList;
		public List<string> enableCommonCharaList;
		private int eventId;
		private EventKindType eventType;
		public bool onCharaTouchMode;
	
		// Properties
		public static EventQuestTalkDataModel Instance { get; }
	
		// Nested types
		public class TalkSet
		{
			// Fields
			public int id;
			public string charaImage;
			public int imageIndex;
			public string voiceData;
			public string charaName;
			public string text;
			public Vector2 posOffset;
			public Vector2 moveOffset;
	
			// Constructors
			public TalkSet(int id, string charaImage, int imageIndex, string text, string voiceData, string charaName, Vector2 posOffset, Vector2 moveOffset);
		}
	
		public enum RaidCharaTalkCategory0
		{
			Top = 1,
			Result = 2,
			HintMessage = 3,
			QuestDescription = 4,
			ExBattleShowUp = 5
		}
	
		public enum RaidCharaTalkCategory1
		{
			Friendship = 1,
			Reward = 2,
			End = 3,
			BeforeJoin = 4,
			StoryProgress = 5
		}
	
		public enum RaidResultCharaTalkHintMessageCategory1
		{
			FriendShip = 1,
			End = 2,
			BeforeJoin = 3
		}
	
		private enum Clb01TopState0
		{
			StoryClear = 1,
			QuestClear = 2,
			EventEnd = 3,
			UnlockStoryCondition = 4,
			UnlockStoryPU = 5
		}
	
		public enum Clb01TalkCategory0
		{
			Top = 1,
			Result = 2,
			Hint = 3
		}
	
		public enum Clb01TalkTopCategory1
		{
			StoryClear = 1,
			EventEnd = 2,
			Redeemable = 3
		}
	
		public enum Clb01TalkResultCategory1
		{
			BeforeJoin = 1,
			Friendship = 2,
			Max = 3
		}
	
		public enum Clb01UnlockStoryPUCategory1
		{
			Normal = 1,
			Insufficient = 2
		}
	
		public enum ExHunterTalkCategory0
		{
			Top = 1,
			Result = 2,
			Hint = 3
		}
	
		public enum ExHunterTalkTopCategory1
		{
			StoryClear = 1,
			Redeemable = 2,
			EventEnd = 3
		}
	
		public enum CombatEventTalkCategory0
		{
			Top = 1,
			Result = 2,
			Hint = 3
		}
	
		public enum CombatEventTalkTopCategory1
		{
			Quest = 1,
			ExQuest = 2,
			Story = 3,
			TradeItem = 4,
			Normal = 5,
			Touch = 6,
			EventEnd = 7
		}
	
		public enum BattleRoyalTalkTopCategory
		{
			Top = 1,
			Result = 2,
			Hint = 3
		}
	
		public enum EarnEventTalkCategory0
		{
			Top = 1,
			Result = 2,
			Hint = 3,
			QuestDescription = 4
		}
	
		public enum EarnEventTalkEventTopCategory1
		{
			QuestClear = 1,
			Touch = 2,
			EventEnd = 3
		}
	
		public enum EarnEventTalkQuestResultCategory1
		{
			ScoreResultStart = 1,
			ScoreResultPresentation = 2,
			ScoreResultRewardGet = 3
		}
	
		public enum EarnEventTalkHintCategory1
		{
			StoryRead = 1,
			EventEnd = 2
		}
	
		public enum EarnEventTalkQuestDecscriptionCategory1
		{
			RewardQuest = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0
		{
			// Fields
			public Clb01TalkCategory0 category0;
			public Clb01TalkResultCategory1 category1;
	
			// Constructors
			public __c__DisplayClass36_0();
	
			// Methods
			internal bool _GetFriendshipResultTalk_b__0(Clb01EventTalkElement x);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<Clb01EventTalkElement, int> __9__36_1;
			public static Func<Clb01EventTalkElement, Guid> __9__36_2;
			public static Func<TalkSet, Guid> __9__48_1;
			public static Func<BoxSummonDataElement, bool> __9__54_1;
			public static Func<RaidEventTalkElement, int> __9__54_3;
			public static Func<RaidEventTalkElement, bool> __9__54_4;
			public static Func<RaidEventTalkElement, int> __9__54_5;
			public static Func<RaidEventTalkElement, Guid> __9__54_0;
			public static Func<BuildEventTalkElement, int> __9__54_8;
			public static Func<BuildEventTalkElement, int> __9__54_11;
			public static Func<BuildEventTalkElement, Guid> __9__54_9;
			public static Func<int, Guid> __9__54_12;
			public static Func<Clb01EventTalkElement, int> __9__54_13;
			public static Func<ExHunterEventTalkElement, int> __9__54_14;
			public static Func<ExHunterEventTalkElement, Guid> __9__54_15;
			public static Func<BoxSummonDataElement, bool> __9__54_16;
			public static Func<ExHunterEventTalkElement, Guid> __9__54_17;
			public static Func<CombatEventTalkElement, int> __9__54_18;
			public static Func<BattleRoyalEventTalkElement, int> __9__54_20;
			public static Func<BattleRoyalEventTalkElement, Guid> __9__54_21;
			public static Func<EarnEventTalkElement, int> __9__54_22;
			public static Func<EarnEventTalkElement, Guid> __9__54_24;
			public static Func<EarnEventTalkElement, bool> __9__54_25;
			public static Func<EarnEventTalkElement, Guid> __9__54_27;
			public static Func<Clb01EventTopElement, int> __9__55_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _GetFriendshipResultTalk_b__36_1(Clb01EventTalkElement x);
			internal Guid _GetFriendshipResultTalk_b__36_2(Clb01EventTalkElement x);
			internal Guid _GetAvailableTalk_b__48_1(TalkSet x);
			internal bool _GatherAvailableTalks_b__54_1(BoxSummonDataElement item);
			internal int _GatherAvailableTalks_b__54_3(RaidEventTalkElement x);
			internal bool _GatherAvailableTalks_b__54_4(RaidEventTalkElement x);
			internal int _GatherAvailableTalks_b__54_5(RaidEventTalkElement x);
			internal Guid _GatherAvailableTalks_b__54_0(RaidEventTalkElement x);
			internal int _GatherAvailableTalks_b__54_8(BuildEventTalkElement x);
			internal int _GatherAvailableTalks_b__54_11(BuildEventTalkElement x);
			internal Guid _GatherAvailableTalks_b__54_9(BuildEventTalkElement x);
			internal Guid _GatherAvailableTalks_b__54_12(int x);
			internal int _GatherAvailableTalks_b__54_13(Clb01EventTalkElement x);
			internal int _GatherAvailableTalks_b__54_14(ExHunterEventTalkElement x);
			internal Guid _GatherAvailableTalks_b__54_15(ExHunterEventTalkElement x);
			internal bool _GatherAvailableTalks_b__54_16(BoxSummonDataElement item);
			internal Guid _GatherAvailableTalks_b__54_17(ExHunterEventTalkElement x);
			internal int _GatherAvailableTalks_b__54_18(CombatEventTalkElement x);
			internal int _GatherAvailableTalks_b__54_20(BattleRoyalEventTalkElement x);
			internal Guid _GatherAvailableTalks_b__54_21(BattleRoyalEventTalkElement x);
			internal int _GatherAvailableTalks_b__54_22(EarnEventTalkElement x);
			internal Guid _GatherAvailableTalks_b__54_24(EarnEventTalkElement x);
			internal bool _GatherAvailableTalks_b__54_25(EarnEventTalkElement x);
			internal Guid _GatherAvailableTalks_b__54_27(EarnEventTalkElement x);
			internal int _GetClb01EventTopElement_b__55_0(Clb01EventTopElement x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0
		{
			// Fields
			public int playingId;
	
			// Constructors
			public __c__DisplayClass48_0();
	
			// Methods
			internal bool _GetAvailableTalk_b__0(TalkSet x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public RaidCharaTalkCategory1 category1;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal bool _GatherAvailableTalks_b__2(RaidEventTalkElement x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_1
		{
			// Fields
			public RaidEventTalkElement lastData;
	
			// Constructors
			public __c__DisplayClass54_1();
	
			// Methods
			internal bool _GatherAvailableTalks_b__6(RaidEventTalkElement x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_2
		{
			// Fields
			public RaidCharaTalkCategory0 category0;
			public EventQuestModel.BuildCharaTalkCategory1 category1;
	
			// Constructors
			public __c__DisplayClass54_2();
	
			// Methods
			internal bool _GatherAvailableTalks_b__7(BuildEventTalkElement x);
			internal bool _GatherAvailableTalks_b__10(BuildEventTalkElement x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_3
		{
			// Fields
			public EarnEventTalkElement lastData;
	
			// Constructors
			public __c__DisplayClass54_3();
	
			// Methods
			internal bool _GatherAvailableTalks_b__26(EarnEventTalkElement x);
		}
	
		// Constructors
		public EventQuestTalkDataModel();
		static EventQuestTalkDataModel();
	
		// Methods
		public static void DeleteInstance();
		public static bool IsInstanceNull();
		private List<int> Clb01AddTopMiniChara(Clb01EventTopElement elem);
		public TalkSet SwitchToMiniCharaAndTalk(int index);
		public void Setup(int eventId, EventKindType eventType);
		public void Clear();
		public TalkSet GetFriendshipResultTalk(int friendship, bool forceMax);
		public TalkSet GetBuildResultTalk(EventQuestModel.BuildCharaTalkResultCategory1 category, EventQuestModel.BuildCharaTalkResultTargetType targetType);
		public TalkSet GetCombatTalk(EventQuestModel.BuildCharaTalkResultCategory1 category, EventQuestModel.BuildCharaTalkResultTargetType targetType);
		public TalkSet GetEarnTalk(EventQuestModel.BuildCharaTalkResultCategory1 category, EventQuestModel.BuildCharaTalkResultTargetType targetType);
		private TalkSet WrapClb01Talk(Clb01EventTalkElement item);
		private TalkSet WrapBattleRoyalTalk(BattleRoyalEventTalkElement item);
		private TalkSet WrapExHunterTalk(ExHunterEventTalkElement item);
		private TalkSet WrapExRushTalk(ExRushEventTalkElement item);
		private TalkSet WrapRaidTalk(RaidEventTalkElement item);
		private TalkSet WrapBuildTalk(BuildEventTalkElement item);
		private TalkSet WrapCombatTalk(CombatEventTalkElement item);
		private TalkSet WrapEarnTalk(EarnEventTalkElement item);
		public TalkSet GetAvailableTalk();
		public TalkSet GetCurrentPlayingTalk();
		public ValueTuple<string, string, string> GetStoryUnlockConditionText(int payEventItemId);
		private string ConvertTopCharaImage(string imageName);
		private Dictionary<string, string> GetBuildChangeCharaDictionary(BuildEventTalk talkData);
		private string GetTopCharaImageWithCharaChangeDic(BuildEventTalkElement item, Dictionary<string, string> changeCharaDic);
		public void GatherAvailableTalks();
		public static Clb01EventTopElement GetClb01EventTopElement(int eventId);
		public static string GetEarnHintMessage(int curEventId);
		public static string GetEarnQuestDescription(int curEventId, EarnEventTalkQuestDecscriptionCategory1 category1);
		[CompilerGenerated]
		private bool _GatherAvailableTalks_b__54_19(BattleRoyalEventTalkElement x);
		[CompilerGenerated]
		private bool _GatherAvailableTalks_b__54_23(EarnEventTalkElement x);
	}
}

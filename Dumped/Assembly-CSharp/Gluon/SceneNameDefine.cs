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
	public class SceneNameDefine
	{
		// Fields
		public const string Boot = "Boot";
		public const string Title = "Title";
		public const string LoadIndex = "LoadIndex";
		public const string DownLoad = "Download";
		public const string LoginBonus = "LoginBonus";
		public const string EmptyLoginBonus = "EmptyLoginBonus";
		public const string SummonUpdated = "SummonUpdated";
		public const string MyPage = "MyPage";
		public const string Guild = "Guild";
		public const string Growth = "Growth";
		public const string CraftDismantleWeapon = "CraftDismantleWeapon";
		public const string CraftGradeup = "CraftGradeup";
		public const string CraftNextStepSelect = "CraftNextStepSelect";
		public const string CraftTargetSelect = "CraftTargetSelect";
		public const string GrowthBaseSelect = "GrowthBaseSelect";
		public const string GrowthLimitBreak = "GrowthLimitBreak";
		public const string GrowthManaCircle = "GrowthManaCircle";
		public const string GrowthSecondManaCircle = "GrowthSecondManaCircle";
		public const string GrowthManaCircle2D = "GrowthManaCircle2D";
		public const string GrowthManaCircleBlank = "GrowthManaCircleBlank";
		public const string GrowthMaterialSelect = "GrowthMaterialSelect";
		public const string GrowthWeapon = "GrowthWeapon";
		public const string GrowthUnitEnhance = "GrowthUnitEnhance";
		public const string PartyBase = "PartyBase";
		public const string Party = "Party";
		public const string PartyCharacter = "PartyCharacter";
		public const string PartyEquip = "PartyEquip";
		public const string PartyDefaultProbe = "PartyDefaultProbe";
		public const string SellList = "SellList";
		public const string FortMenu = "FortMenu";
		public const string Fort = "Fort";
		public const string DragonStroke = "DragonStroke";
		public const string UnitStoryList = "UnitStoryList";
		public const string SummonShop = "SummonShop";
		public const string ShopTrade = "ShopTrade";
		public const string SummonBGScene = "SummonBGScene";
		public const string QuestSelect = "QuestSelect";
		public const string NormalEventSelect = "NormalEventSelect";
		public const string QuestSupportSelect = "QuestSupportSelect";
		public const string QuestResult = "QuestResult";
		public const string QuestFailedResult = "QuestFailedResult";
		public const string Retry = "Retry";
		public const string EventQuest = "EventQuest";
		public const string EventQuestRanking = "EventQuestRanking";
		public const string UnitDetail = "UnitDetail";
		public const string InGameBlank = "InGameBlank";
		public const string Friend = "Friend";
		public const string InGame = "InGame";
		public const string MissionDrill = "MissionDrill";
		public const string TutorialSummon = "TutorialSummon";
		private static Dictionary<PageName, string> pageNameDic;
		private static Dictionary<EventKindType, string> overrideEventTopPageNameDic;
		private static Dictionary<EventKindType, string> overrideEventQuestListPageNameDic;
	
		// Nested types
		public enum PageName
		{
			None = 0,
			QuestSelectChapter = 1,
			QuestSelectArea = 2,
			QuestSelectMainDetail = 3,
			QuestSelectSupport = 4,
			QuestSelectEventTop = 5,
			QuestSelectEventSub = 6,
			QuestSelectMemoryEvent = 7,
			QuestSelectEventDetail = 8,
			EventQuestList = 9,
			EventQuestTop = 10,
			EventQuestBoxSummon = 11,
			EventQuestBoxSummonAnim = 12,
			EventQuestReward = 13,
			EventQuestRandomReward = 14,
			EventQuestExchange = 15,
			EventQuestRankingTop = 16,
			EventQuestRankingList = 17,
			EventQuestDetailListPage = 18,
			LoginBonusMain = 19,
			LoginBonusEvent = 20,
			LoginBonusCharacter = 21,
			CombatQuestMap = 22,
			BattleRoyalSelectJobSkin = 23,
			BattleRoyalSkinSetting = 24,
			CLB01_QuestMap = 214010,
			ExRush_Top = 218010,
			TutorialSummonPage = 218011,
			TutorialSummonResultPage = 218012
		}
	
		// Constructors
		public SceneNameDefine();
		static SceneNameDefine();
	
		// Methods
		public static string GetPagePath(PageName pageName);
	}
}

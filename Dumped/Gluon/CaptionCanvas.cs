using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CaptionCanvas : AnimationUICanvas
	{
		public enum IconType
		{
			Top_Title_Mypage,
			Top_Title_Menu,
			Player_Title_Menu,
			Record_Title_Menu,
			Friend_Title_Menu,
			Profile_Title_Menu,
			Stamp_Title_Menu,
			Result_Title_Menu,
			Main_Title_Friend,
			Search_Title_Friend,
			Request_Title_Friend,
			Consent_Title_Friend,
			Support_Title_Friend,
			Story_Title_Record,
			Unit_Title_Record,
			Enemy_Title_Record,
			Library_Title_Record,
			Quest_Title_Mypage,
			Multi_Title_Mypage,
			Top_Title_Growth,
			Chara_Title_Growth,
			Mana_Title_Growth,
			Dragon01_Title_Growth,
			Dragon02_Title_Growth,
			Weapon01_Title_Growth,
			Weapon02_Title_Growth,
			Amulet01_Title_Growth,
			Amulet02_Title_Growth,
			Top_Title_Party,
			List_Title_Party,
			Top_Title_Fort,
			Main_Title_Fort,
			Knights_Title_Fort,
			Dragon_Title_Fort,
			Castle_Title_Fort,
			Top_Title_Summon,
			Episode_Title_Summon,
			RollOnly_Title_Summon,
			Roll01_Title_Summon,
			Roll10_Title_Summon,
			Shop_Title_Menu,
			BuyStone_Title_Record,
			BuyItem_Title_Shop,
			ItemTrade_Title_Shop,
			TreasureTrade_Title_Shop,
			MoonTrade_Title_Shop,
			Exchange_Title_Shop,
			UseItem_Title_Shop,
			Emblem_Title_Event,
			MedalReward_Title_Event,
			Exchange_Title_Event,
			LimitedQuest_Title_Shop,
			Summon_Title_Event,
			SummonResult_Title_Event,
			Sizuku_Title_Shop,
			Event_Quest_Title,
			Pack_Title_Shop,
			Pack2_Title_Shop,
			Item1_Title_Shop,
			Item2_Title_Shop,
			Item3_Title_Shop,
			Item4_Title_Shop,
			Trade_Title_Shop,
			Craft_Title_Growth,
			Amulet_Title_Shop,
			MissionDrill_Title,
			Diary_Title_Album,
			BattleRecord_Title_Album,
			Story_Title_Album,
			Dmode_Title_FafnirGrowth,
			Dmode_Title_Story
		}

		public GameObject[] bg;

		public Image icon;

		public Text title;

		private ThemeColor currentThemeColor;

		public void SetContent(string titleText, ThemeColor themeColor, IconType iconType)
		{
		}

		private IEnumerator SetTypeCoroutine(string titleText, ThemeColor themeColor, IconType iconType)
		{
			return null;
		}

		private void SetTypeImpl(string titleText, ThemeColor themeColor, IconType iconType)
		{
		}

		public void SlideOut([Optional] Action onDone)
		{
		}

		public bool IsSameTitle(string titleText, ThemeColor themeColor)
		{
			return default(bool);
		}
	}
}

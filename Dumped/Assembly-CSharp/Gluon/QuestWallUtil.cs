/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestWallUtil : MonoBehaviour
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public Image image;
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _SetQuestThumbnail_b__0(Material material);
		}
	
		// Constructors
		public QuestWallUtil();
	
		// Methods
		public static bool IsQuestWallFromQuestId(int wallId);
		public static bool IsQuestWallFromQuestEventMenu(QuestEventMenuElement qeme);
		public static bool IsQuestWallFromQuestEvent(QuestEventElement qee);
		public static QuestWallList GetQuestWallList(int questId);
		public static QuestWallDetailElement GetQuestWallDetailElement(int wallId, int wallLevel);
		public static int GetQuestWallLevel(int questid);
		public static int GetNextQuestQuestWallLevel(int wallId);
		public static int GetMaxQuestWall(int wallId);
		public static void SetQuestThumbnail(QuestWallElement questData, Image image, bool isUnknown, Action onComplete = null);
		public static QuestUtil.QuestState GetQuestWallState(QuestWallElement qwe);
		public static bool IsBattlePowerEnough(QuestWallDetailElement questDataElement);
		public static bool IsQuestWallEnabled(QuestWallElement questWallElement);
		public static bool IsQuestWallDetailEnabled(QuestWallDetailElement questWallDetailElement);
		public static bool IsQuestWallPrologueIdDone(QuestEventGroupElement groupElement);
		public static QuestWallMonthlyRewardElement GetQuestWallMonthlyRewardElement(int level);
		public static QuestWallMonthlyRewardElement GetNextQuestWallMonthlyRewardElement(int level);
		public static QuestWallMonthlyRewardElement GetQuestWallMonthlyRewardElementNextPickUp(int level);
		public static List<QuestWallMonthlyRewardElement> GetWithinPeriodQuestWallMonthlyRewardElement();
		public static QuestWallElement GetQuestWall(int wallId);
		public static bool IsEnable(QuestWallElement dataElement);
		public static int GetEffectStage(int level);
		public static string GetWallResetTime();
		public static bool IsLimitedElementalWallQuest(int wallId, out ElementalType limitedElementalType);
	}
}

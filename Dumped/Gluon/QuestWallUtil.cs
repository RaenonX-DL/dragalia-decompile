using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestWallUtil : MonoBehaviour
	{
		public static bool IsQuestWallFromQuestId(int wallId)
		{
			return default(bool);
		}

		public static bool IsQuestWallFromQuestEventMenu(QuestEventMenuElement qeme)
		{
			return default(bool);
		}

		public static bool IsQuestWallFromQuestEvent(QuestEventElement qee)
		{
			return default(bool);
		}

		public static QuestWallList GetQuestWallList(int questId)
		{
			return null;
		}

		public static QuestWallDetailElement GetQuestWallDetailElement(int wallId, int wallLevel)
		{
			return null;
		}

		public static int GetQuestWallLevel(int questid)
		{
			return default(int);
		}

		public static int GetNextQuestQuestWallLevel(int wallId)
		{
			return default(int);
		}

		public static int GetMaxQuestWall(int wallId)
		{
			return default(int);
		}

		public static void SetQuestThumbnail(QuestWallElement questData, Image image, bool isUnknown, [Optional] Action onComplete)
		{
		}

		public static QuestUtil.QuestState GetQuestWallState(QuestWallElement qwe)
		{
			return default(QuestUtil.QuestState);
		}

		public static bool IsBattlePowerEnough(QuestWallDetailElement questDataElement)
		{
			return default(bool);
		}

		public static bool IsQuestWallEnabled(QuestWallElement questWallElement)
		{
			return default(bool);
		}

		public static bool IsQuestWallDetailEnabled(QuestWallDetailElement questWallDetailElement)
		{
			return default(bool);
		}

		public static bool IsQuestWallPrologueIdDone(QuestEventGroupElement groupElement)
		{
			return default(bool);
		}

		public static QuestWallMonthlyRewardElement GetQuestWallMonthlyRewardElement(int level)
		{
			return null;
		}

		public static QuestWallMonthlyRewardElement GetNextQuestWallMonthlyRewardElement(int level)
		{
			return null;
		}

		public static QuestWallMonthlyRewardElement GetQuestWallMonthlyRewardElementNextPickUp(int level)
		{
			return null;
		}

		public static List<QuestWallMonthlyRewardElement> GetWithinPeriodQuestWallMonthlyRewardElement()
		{
			return null;
		}

		public static QuestWallElement GetQuestWall(int wallId)
		{
			return null;
		}

		public static bool IsEnable(QuestWallElement dataElement)
		{
			return default(bool);
		}

		public static int GetEffectStage(int level)
		{
			return default(int);
		}

		public static string GetWallResetTime()
		{
			return null;
		}

		public static bool IsLimitedElementalWallQuest(int wallId, out ElementalType limitedElementalType)
		{
			return default(bool);
		}
	}
}

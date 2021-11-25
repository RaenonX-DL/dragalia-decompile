using System;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class EventListCtrl : QuestListBase
	{
		public enum BuildEventDifficulty
		{
			Normal = 1,
			Hard
		}

		[SerializeField]
		private Transform contentTransform;

		private EventQuestModel eventQuestModel;

		public AnimationListOneCol listAnimation;

		private static Dictionary<int, float> scrollPosDic;

		public BuildEventDifficulty difficulty;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void ClearScrollPos()
		{
		}

		private bool IsCurEventEnablePeriod()
		{
			return default(bool);
		}

		private TimeSpan QuestEventMenuEnableDateDiff(List<QuestEventMenuElement> cellData)
		{
			return default(TimeSpan);
		}

		private bool IsQuestEventMenuEnabledByDate(List<QuestEventMenuElement> cellData)
		{
			return default(bool);
		}

		private bool IsHighLevelQuest(int subType)
		{
			return default(bool);
		}

		private void CreateEventMenus(Dictionary<int, List<QuestEventMenuElement>> dataList)
		{
		}

		private void CreateEventCell(GameObject raidCellPrefab, int subType, List<QuestEventMenuElement> cellData, QuestUtil.QuestState questState, ref int delayIndex)
		{
		}

		public float ScrollToItem(RaidEventCell raidEventCell)
		{
			return default(float);
		}

		private void CreateEventTitle(string titleValue, ref int delayIndex)
		{
		}

		private void CreateNormalCell(GameObject normalCellPrefab, int subType, QuestType questType, QuestUtil.QuestState questState, QuestEventMenuElement previouCellData, QuestEventMenuElement cellData, bool isCurEventEnablePeriod, ref int delayIndex)
		{
		}

		private void CreateNormalCellWithArrow(GameObject normalCellPrefab, int subType, QuestType questType, QuestUtil.QuestState questState, QuestEventMenuElement cellData, ref int delayIndex, bool isArrowEnable)
		{
		}

		private void CreateEventMenus(List<QuestEventMenuElement> dataes)
		{
		}

		public void StartEnterAnimation(float delayTime = 0f)
		{
		}

		public void StartExitAnimation(float delayTime = 0f)
		{
		}

		public bool IsOnAnimation()
		{
			return default(bool);
		}
	}
}

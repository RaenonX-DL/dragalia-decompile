/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventListCtrl : QuestListBase
	{
		// Fields
		[SerializeField]
		private Transform contentTransform;
		private EventQuestModel eventQuestModel;
		public AnimationListOneCol listAnimation;
		private static Dictionary<int, float> scrollPosDic;
		public BuildEventDifficulty difficulty;
	
		// Nested types
		public enum BuildEventDifficulty
		{
			Normal = 1,
			Hard = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public Dictionary<int, List<QuestEventMenuElement>> dataList;
			public EventListCtrl __4__this;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal int _CreateEventMenus_b__0(int a, int b);
			internal int _CreateEventMenus_b__1(int x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public RectTransform rt;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _ScrollToItem_b__0(float y);
		}
	
		// Constructors
		public EventListCtrl();
		static EventListCtrl();
	
		// Methods
		private void Start();
		private void OnDestroy();
		private void ClearScrollPos();
		private bool IsCurEventEnablePeriod();
		private TimeSpan QuestEventMenuEnableDateDiff(List<QuestEventMenuElement> cellData);
		private bool IsQuestEventMenuEnabledByDate(List<QuestEventMenuElement> cellData);
		private bool IsHighLevelQuest(int subType);
		private void CreateEventMenus(Dictionary<int, List<QuestEventMenuElement>> dataList);
		private void CreateEventCell(GameObject raidCellPrefab, int subType, List<QuestEventMenuElement> cellData, QuestUtil.QuestState questState, ref int delayIndex);
		public float ScrollToItem(RaidEventCell raidEventCell);
		private void CreateEventTitle(string titleValue, ref int delayIndex);
		private void CreateNormalCell(GameObject normalCellPrefab, int subType, QuestType questType, QuestUtil.QuestState questState, QuestEventMenuElement previouCellData, QuestEventMenuElement cellData, bool isCurEventEnablePeriod, ref int delayIndex);
		private void CreateNormalCellWithArrow(GameObject normalCellPrefab, int subType, QuestType questType, QuestUtil.QuestState questState, QuestEventMenuElement cellData, ref int delayIndex, bool isArrowEnable);
		private void CreateEventMenus(List<QuestEventMenuElement> dataes);
		public void StartEnterAnimation(float delayTime = 0f);
		public void StartExitAnimation(float delayTime = 0f);
		public bool IsOnAnimation();
	}
}

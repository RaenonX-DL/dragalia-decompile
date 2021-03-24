/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventRankingListController : QuestCommonTableViewController<Gluon.EventRankingListCellData>
	{
		// Fields
		public float cellWidth;
		public float cellHeight;
		public EventRankingListBase eventRankingListBase;
	
		// Nested types
		public class UserRanking
		{
			// Fields
			public int rank;
			public int clearTime;
			public List<EventRankingListCellData.RankingPartyMemberInfo> memberList;
	
			// Constructors
			public UserRanking();
		}
	
		// Constructors
		public EventRankingListController();
	
		// Methods
		protected override void Awake();
		public void SetOnScrollPosChangedEvent(UnityAction<Vector2> call);
		public Vector2 LoadData(UserRanking[] rankingData, int targetRank, bool isNewTableData = true);
		public void UpdateScrollPos(Vector2 pos);
		public void SetScrollEnable(bool value);
		public void GetCurTableDataRankingRange(out int startRank, out int endRank);
		public void Reload();
		public void ClearList();
		protected override TableViewCell<EventRankingListCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		protected override void LateUpdate();
		[CompilerGenerated]
		private void _CreateCellForIndex_b__12_0(int cellIndex);
	}
}

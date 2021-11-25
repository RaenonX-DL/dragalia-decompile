using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class EventRankingListController : QuestCommonTableViewController<EventRankingListCellData>
	{
		public class UserRanking
		{
			public int rank;

			public int clearTime;

			public List<EventRankingListCellData.RankingPartyMemberInfo> memberList;
		}

		public float cellWidth;

		public float cellHeight;

		public EventRankingListBase eventRankingListBase;

		protected override void Awake()
		{
		}

		public void SetOnScrollPosChangedEvent(UnityAction<Vector2> call)
		{
		}

		public Vector2 LoadData(UserRanking[] rankingData, int targetRank, bool isNewTableData = true)
		{
			return default(Vector2);
		}

		public void UpdateScrollPos(Vector2 pos)
		{
		}

		public void SetScrollEnable(bool value)
		{
		}

		public void GetCurTableDataRankingRange(out int startRank, out int endRank)
		{
		}

		public void Reload()
		{
		}

		public void ClearList()
		{
		}

		protected override TableViewCell<EventRankingListCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}

		protected override void LateUpdate()
		{
		}
	}
}

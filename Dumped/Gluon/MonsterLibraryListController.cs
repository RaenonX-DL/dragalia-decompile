using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class MonsterLibraryListController : TableViewController<MonsterLibraryListData>
	{
		public GameObject originTrideCell;

		public const float cellWidth = 96f;

		public const float cellHeight = 96f;

		public GameObject listBaseObject;

		private static MonsterLibraryListSort nowSortType;

		private float tribeListOffsetY;

		private Dictionary<TribeType, MonsterTribeDictData> monsterTribeDictionary;

		private LinkedList<GameObject> tribeCells;

		private float tribeCellHeight;

		protected override void Start()
		{
		}

		protected void LoadData()
		{
		}

		public void SortList(MonsterLibraryListSort sortType)
		{
		}

		private static int MonsterListSort(MonsterLibraryListData currCell, MonsterLibraryListData nextCell)
		{
			return default(int);
		}

		protected override void UpdateContentSize()
		{
		}

		protected override void UpdateVisibleRect()
		{
		}

		protected override TableViewCell<MonsterLibraryListData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override void ReuseCells(int scrollDirection)
		{
		}

		protected override Vector2 GetNextCellPos(TableViewCell<MonsterLibraryListData> cell, int increment)
		{
			return default(Vector2);
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}

		private void AddTribeDataCell(TribeType type, Vector3 cellPos)
		{
		}

		private void ClearTribeCellsList()
		{
		}
	}
}

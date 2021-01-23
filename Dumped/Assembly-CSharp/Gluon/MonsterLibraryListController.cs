/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MonsterLibraryListController : TableViewController<Gluon.MonsterLibraryListData>
	{
		// Fields
		public GameObject originTrideCell;
		public const float cellWidth = 96f;
		public const float cellHeight = 96f;
		public GameObject listBaseObject;
		private static MonsterLibraryListSort nowSortType;
		private float tribeListOffsetY;
		private Dictionary<TribeType, MonsterTribeDictData> monsterTribeDictionary;
		private LinkedList<GameObject> tribeCells;
		private float tribeCellHeight;
	
		// Constructors
		public MonsterLibraryListController();
		static MonsterLibraryListController();
	
		// Methods
		protected override void Start();
		protected void LoadData();
		public void SortList(MonsterLibraryListSort sortType);
		private static int MonsterListSort(MonsterLibraryListData currCell, MonsterLibraryListData nextCell);
		protected override void UpdateContentSize();
		protected override void UpdateVisibleRect();
		protected override TableViewCell<MonsterLibraryListData> CreateCellForIndex(int index);
		protected override void ReuseCells(int scrollDirection);
		protected override Vector2 GetNextCellPos(TableViewCell<MonsterLibraryListData> cell, int increment);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		private void AddTribeDataCell(TribeType type, Vector3 cellPos);
		private void ClearTribeCellsList();
		[CompilerGenerated]
		private void _CreateCellForIndex_b__15_0(int cellIndex);
	}
}

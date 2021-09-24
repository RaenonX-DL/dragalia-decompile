/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OtherUserClearPartyListController : TableViewController<Gluon.OtherUserClearPartyListCellData>
	{
		// Fields
		public Action<OtherUserClearPartyListCellData, int> sampleButtonCallBack;
		public GameObject emptyListTextObj;
		public float cellWidth;
		public float cellHeight;
		public float partySwitchCellHeight;
		public OtherUserClearPartyCellType cellType;
		public GameObject[] listOriginalCells;
		private const int maxListCellCount = 20;
	
		// Properties
		public bool hasListData { get; }
	
		// Nested types
		public enum OtherUserClearPartyCellType
		{
			normalType = 0,
			partySwitchType = 1
		}
	
		// Constructors
		public OtherUserClearPartyListController();
	
		// Methods
		public void LoadList(int questId, int pageIdex);
		protected override TableViewCell<OtherUserClearPartyListCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		private GameObject GetOriginCellObject(OtherUserClearPartyCellType type);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__12_0(int cellIndex, int partySwitchIndex);
	}
}

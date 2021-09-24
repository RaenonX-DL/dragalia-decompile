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
	public class ClearPartyEquipSampleListController : TableViewController<Gluon.ClearPartyEquipSampleListCellData>
	{
		// Fields
		public Action<ClearPartyEquipSampleListCellData, int> setButtonCallBack;
		[SerializeField]
		private Vector2 soloPartyCellSize;
		[SerializeField]
		private Vector2 multiPartyCellSize;
		private bool isSoloQuest;
		private static readonly string clearPartySoloCellPath;
		private static readonly string clearPartyMultiCellPath;
	
		// Constructors
		public ClearPartyEquipSampleListController();
		static ClearPartyEquipSampleListController();
	
		// Methods
		public void LoadOriginalCell(bool isSoloQuest);
		public void LoadList(bool isSoloQuest);
		protected override TableViewCell<ClearPartyEquipSampleListCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__8_0(int cellIndex, int indexInParty);
	}
}

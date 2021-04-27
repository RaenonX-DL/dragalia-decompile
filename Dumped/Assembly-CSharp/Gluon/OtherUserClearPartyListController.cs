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
		public Action<OtherUserClearPartyListCellData> sampleButtonCallBack;
		public GameObject emptyListTextObj;
		public float cellWidth;
		public float cellHeight;
		private const int maxListCellCount = 20;
	
		// Properties
		public bool hasListData { get; }
	
		// Constructors
		public OtherUserClearPartyListController();
	
		// Methods
		public void LoadList(int questId, int pageIdex);
		protected override TableViewCell<OtherUserClearPartyListCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__8_0(int cellIndex);
	}
}

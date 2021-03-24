/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestRoomListController : TableViewController<Gluon.RoomListData>
	{
		// Fields
		private float cellWidth;
		private float cellHeightShort;
		private float cellHeightLong;
		public UnityAction<RoomList> listButtonCallBack;
		public string originalCellPrefabPath;
		[SerializeField]
		private UnityEngine.UI.Text nothingText;
		private const int paddingBottomLayoutHeight = 80;
	
		// Constructors
		public QuestRoomListController();
	
		// Methods
		protected override void Awake();
		public void LoadData(List<RoomListData> data);
		protected override TableViewCell<RoomListData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		public void SetText(bool enable);
		public void ClearCells();
		[CompilerGenerated]
		private void _CreateCellForIndex_b__9_0(int cellIndex);
	}
}

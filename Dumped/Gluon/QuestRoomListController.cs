using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestRoomListController : TableViewController<RoomListData>
	{
		private float cellWidth;

		private float cellHeightShort;

		private float cellHeightLong;

		public UnityAction<RoomList> listButtonCallBack;

		public string originalCellPrefabPath;

		[SerializeField]
		private Text nothingText;

		private const int paddingBottomLayoutHeight = 80;

		protected override void Awake()
		{
		}

		public void LoadData(List<RoomListData> data)
		{
		}

		protected override TableViewCell<RoomListData> CreateCellForIndex(int index)
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

		public void SetText(bool enable)
		{
		}

		public void ClearCells()
		{
		}
	}
}

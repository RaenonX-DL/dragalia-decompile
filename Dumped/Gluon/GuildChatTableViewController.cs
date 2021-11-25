using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class GuildChatTableViewController : TableViewController<GuildChatModel.ChatTableViewData>
	{
		public Transform invisibleNode;

		private GuildChatTableViewCell sizingCell;

		private Dictionary<Guid, Vector2> cellHeightTable;

		private Coroutine updateSizeCoroutine;

		private Coroutine updateWaitAnimationCoroutine;

		private int defaultCreateCellCount;

		private readonly Vector2 scrollToBottomOffset;

		private const float cellApperSpace = 10f;

		protected override void Awake()
		{
		}

		private void CreateDummyCells(int createCount)
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		public void UpdateByData(List<GuildChatModel.ChatTableViewData> data, bool isNew, bool isChatoBottom, bool isFirst, Action onFinshed)
		{
		}

		private IEnumerator UpdateByDataCoroutine(List<GuildChatModel.ChatTableViewData> dataList, bool isNew, bool isChatoBottom, bool isFirst, Action onFinshed)
		{
			return null;
		}

		private void UpdateScroll(bool isNew, bool isChatoBottom, bool isFirst)
		{
		}

		public float GetHeightFromBottomToHere()
		{
			return default(float);
		}

		public bool IsViewingLatestChat(float space)
		{
			return default(bool);
		}

		public void HideAnimationWaitCell()
		{
		}

		private IEnumerator UpdateBottomChatCell()
		{
			return null;
		}

		private bool IsExistHideData()
		{
			return default(bool);
		}

		private void CheckAllCellHideState()
		{
		}

		private void CheckCellHideState(GuildChatTableViewCell cell, float limit)
		{
		}

		private void ResetHideCell()
		{
		}
	}
}

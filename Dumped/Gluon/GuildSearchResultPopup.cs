using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class GuildSearchResultPopup : PopupBase
	{
		[SerializeField]
		[Header("Recommended")]
		public GuildInfoTableViewController searchList;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildSearchResultPopup";

		private List<GuildInfoCellData> cellDataList;

		private GuildInfoCellData.FilterOption filter;

		private Action<int, GuildInfoCellData, Action> onApply;

		public static GuildSearchResultPopup Create(List<GuildInfoCellData> dataList, Action<int, GuildInfoCellData, Action> onApply)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnCellPressed(GuildInfoCellData data)
		{
		}
	}
}

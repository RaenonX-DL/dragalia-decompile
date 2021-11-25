using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildSearchPopup : PopupBase
	{
		private enum TabType
		{
			Recommended,
			Name,
			ID,
			Applied
		}

		[SerializeField]
		[Header("TabView")]
		public TabViewBase tabView;

		[SerializeField]
		[Header("Recommended")]
		public GuildInfoTableViewController searchList;

		[SerializeField]
		[Header("Applying")]
		public Transform appliedCellTransform;

		public GameObject noAppliedContent;

		public GameObject appliedContent;

		[SerializeField]
		[Header("Search")]
		public InputField nameInput;

		public InputField idInput;

		[SerializeField]
		[Header("Buttons")]
		public GameObject okButtonGO;

		public Button okButton;

		private GuildInfoTableViewCell appliedCell;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildSearchPopup";

		private List<GuildInfoCellData> cellDataList;

		private GuildInfoCellData.FilterOption filter;

		private TabType currentTab;

		public static void CreateModule()
		{
		}

		private static Task<GuildSearchAutoSearchResponse> RequestRecommendedList(GuildInfoCellData.FilterOption filter)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private int GetValidGuildId(string text)
		{
			return default(int);
		}

		public void OnTabChanged(int tabIndex, int prevTabIndex)
		{
		}

		public void OnSearchButtonPressed()
		{
		}

		private void SearchByName(string name)
		{
		}

		private void SearchById(int guildId)
		{
		}

		private void UpdateRecommendedList()
		{
		}

		public void OnCellPressed(GuildInfoCellData data)
		{
		}

		private void Apply(int guildId, GuildInfoCellData data, [Optional] Action onApplyDone)
		{
		}

		private void UpdateAppliedData()
		{
		}

		public void OnCancelApplyButtonPressed()
		{
		}
	}
}

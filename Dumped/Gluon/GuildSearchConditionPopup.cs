using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildSearchConditionPopup : PopupBase
	{
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildSearchConditionPopup";

		[SerializeField]
		public Toggle[] approvalToggles;

		public Toggle[] activityToggles;

		public Toggle[] populationToggles;

		public Button okButton;

		private Action<GuildInfoCellData.FilterOption> onFilterApplied;

		private GuildInfoCellData.FilterOption filter;

		public static GuildSearchConditionPopup Create(GuildInfoCellData.FilterOption filter, Action<GuildInfoCellData.FilterOption> onFilterApplied)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		public void OnApplyButtonPressed()
		{
		}
	}
}

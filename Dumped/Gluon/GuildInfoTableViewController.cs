using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildInfoTableViewController : TableViewController<GuildInfoCellData>
	{
		[SerializeField]
		[Header("WarningText")]
		public Text noItemText;

		public Text noItemDueToFilterText;

		[SerializeField]
		[Header("Filter")]
		public CommonSortButton sortButton;

		public GameObject filterGO;

		private float cellHeight;

		private List<GuildInfoCellData> originalData;

		private bool isFilterOn;

		private GuildInfoCellData.FilterOption filterOption;

		public Action<GuildInfoCellData.FilterOption, Action<List<GuildInfoCellData>>> requestFilterAction
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action<GuildInfoCellData> onCellPressed
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action<GuildInfoCellData> rejectAction
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		public void HideFilter()
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		public void UpdateByData(List<GuildInfoCellData> data)
		{
		}

		protected override TableViewCell<GuildInfoCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override void UpdateContents()
		{
		}

		private void ApplyFilters()
		{
		}

		public void OnFilterButtonPressed()
		{
		}
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildInfoTableViewController : TableViewController<Gluon.GuildInfoCellData>
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text noItemText;
		public UnityEngine.UI.Text noItemDueToFilterText;
		[Header]
		[SerializeField]
		public CommonSortButton sortButton;
		public GameObject filterGO;
		[CompilerGenerated]
		private Action<GuildInfoCellData.FilterOption, Action<List<GuildInfoCellData>>> _requestFilterAction_k__BackingField;
		[CompilerGenerated]
		private Action<GuildInfoCellData> _onCellPressed_k__BackingField;
		[CompilerGenerated]
		private Action<GuildInfoCellData> _rejectAction_k__BackingField;
		private float cellHeight;
		private List<GuildInfoCellData> originalData;
		private bool isFilterOn;
		private GuildInfoCellData.FilterOption filterOption;
	
		// Properties
		public Action<GuildInfoCellData.FilterOption, Action<List<GuildInfoCellData>>> requestFilterAction { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action<GuildInfoCellData> onCellPressed { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action<GuildInfoCellData> rejectAction { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public GuildInfoTableViewController();
	
		// Methods
		protected override void Awake();
		public void HideFilter();
		protected override float GetCellHeightAtIndex(int index);
		public void UpdateByData(List<GuildInfoCellData> data);
		protected override TableViewCell<GuildInfoCellData> CreateCellForIndex(int index);
		protected override void UpdateContents();
		private void ApplyFilters();
		public void OnFilterButtonPressed();
		[CompilerGenerated]
		private bool _ApplyFilters_b__26_0(GuildInfoCellData item);
		[CompilerGenerated]
		private void _OnFilterButtonPressed_b__27_0(GuildInfoCellData.FilterOption option);
		[CompilerGenerated]
		private void _OnFilterButtonPressed_b__27_1(List<GuildInfoCellData> x);
	}
}

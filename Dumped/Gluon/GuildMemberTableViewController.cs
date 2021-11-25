using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildMemberTableViewController : TableViewController<GuildModel.MemberInfo>
	{
		public enum EditMode
		{
			None,
			Admin,
			Approve,
			Invite
		}

		[SerializeField]
		[Header("WarningText")]
		public Text noItemText;

		[NonSerialized]
		public EditMode editMode;

		private float cellHeight;

		private List<GuildModel.MemberInfo> originalData;

		public Action onRequestLatestData
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

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		public void UpdateByData(List<GuildModel.MemberInfo> data)
		{
		}

		protected override TableViewCell<GuildModel.MemberInfo> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override void UpdateContents()
		{
		}

		public GuildModel.MemberInfo GetSubMasterData()
		{
			return default(GuildModel.MemberInfo);
		}

		private void ApplySort()
		{
		}
	}
}

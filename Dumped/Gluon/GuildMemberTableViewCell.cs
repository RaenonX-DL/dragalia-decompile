using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildMemberTableViewCell : TableViewCell<GuildModel.MemberInfo>
	{
		[SerializeField]
		[Header("Info")]
		public CommonIcon icon;

		public Text levelText;

		public Text playerNameText;

		public Text lastLoginText;

		public Text maxPowerText;

		[SerializeField]
		[Header("Occupation")]
		public GameObject masterGO;

		public GameObject subMasterGO;

		[SerializeField]
		[Header("Button")]
		public GameObject adminButtonGO;

		public GameObject approveButtonGO;

		public GameObject rejectButtonGO;

		public GameObject cancelInviteButtonGO;

		[SerializeField]
		[Header("WaitingInviteMessage")]
		public GameObject waitingInviteGO;

		private GuildMemberTableViewController _controller;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildMemberTableViewCell";

		public GuildMemberTableViewController controller
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public override void UpdateContent(GuildModel.MemberInfo data)
		{
		}

		private void ApplyOnlineStatus()
		{
		}

		private void OnControllerAssigned()
		{
		}

		public void OnAdminButtonPressed()
		{
		}

		public void OnApproveButtonPressed()
		{
		}

		public void OnRejectButtonPressed()
		{
		}

		public void OnCancelInviteButtonPressed()
		{
		}

		public void OnIconPressed()
		{
		}
	}
}

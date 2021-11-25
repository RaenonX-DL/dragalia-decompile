using System;
using UnityEngine;

namespace Gluon
{
	public class GuildMemberAdminPopup : PopupBase
	{
		[SerializeField]
		[Header("Cell")]
		public Transform memberCellParent;

		[SerializeField]
		[Header("SubMaster")]
		public GameObject assignSubMasterGO;

		public GameObject dismissSubMasterGO;

		private GuildMemberTableViewCell cell;

		private GuildModel.MemberInfo data;

		private GuildModel.MemberInfo subMasterData;

		private Action onAnyActionDone;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildMemberAdminPopup";

		public static GuildMemberAdminPopup Create(GuildModel.MemberInfo data, Action onAnyActionDone, GuildModel.MemberInfo currentSubMasterData)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnAssignAsMasterButtonPressed()
		{
		}

		public void OnDismissSubMasterButtonPressed()
		{
		}

		public void OnFireMemberButtonPressed()
		{
		}

		public void OnAssignAsSubMasterButtonPressed()
		{
		}
	}
}

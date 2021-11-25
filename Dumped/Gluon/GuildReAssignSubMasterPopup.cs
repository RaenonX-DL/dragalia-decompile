using System;
using UnityEngine;

namespace Gluon
{
	public class GuildReAssignSubMasterPopup : PopupBase
	{
		[SerializeField]
		[Header("Cell")]
		public Transform memberCellParent;

		private GuildMemberTableViewCell cell;

		private GuildModel.MemberInfo data;

		private GuildModel.MemberInfo subMasterData;

		private Action onAnyActionDone;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildReAssignSubMasterPopup";

		public static GuildReAssignSubMasterPopup Create(GuildModel.MemberInfo data, GuildModel.MemberInfo currentSubMasterData, Action onAnyActionDone)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnAssignAsSubMasterButtonPressed()
		{
		}
	}
}

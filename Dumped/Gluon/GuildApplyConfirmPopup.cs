using System;
using UnityEngine;

namespace Gluon
{
	public class GuildApplyConfirmPopup : PopupBase
	{
		[SerializeField]
		[Header("Components")]
		public GameObject[] applyContents;

		public GameObject[] entryContents;

		public Transform dataNode;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildApplyConfirmPopup";

		private GuildInfoCellData data;

		private Action onApply;

		public static GuildApplyConfirmPopup Create(GuildInfoCellData data, Action onApply)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnApply()
		{
		}
	}
}

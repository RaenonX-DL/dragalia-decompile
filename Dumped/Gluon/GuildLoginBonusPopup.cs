using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class GuildLoginBonusPopup : PopupBase
	{
		[SerializeField]
		[Header("Components")]
		public Transform iconParent;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildLoginBonusPopup";

		private Action onDone;

		private List<EntityData> dataList;

		public static GuildLoginBonusPopup Create(List<EntityData> dataList, Action onDone)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnCloseButtonPressed()
		{
		}
	}
}

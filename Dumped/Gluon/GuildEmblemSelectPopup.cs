using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class GuildEmblemSelectPopup : PopupBase
	{
		[SerializeField]
		[Header("TableViews")]
		public GuildEmblemTableViewController controller;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildEmblemSelectPopup";

		private Action<int> onEditDone;

		public int selectedEmblemId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static GuildEmblemSelectPopup Create(int initEmblemId, Action<int> onEditDone)
		{
			return null;
		}

		public void OnEmblemSelect(int data)
		{
		}

		public void OnOKButtonPressed()
		{
		}
	}
}

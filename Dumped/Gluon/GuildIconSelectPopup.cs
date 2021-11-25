using System;

namespace Gluon
{
	public class GuildIconSelectPopup : PopupBase
	{
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildIconSelectPopup";

		private Action<GuildModel.ProfileIconData> onEditDone;

		[NonSerialized]
		public GuildModel.ProfileIconData selectedIconData;

		public GuildIconTableViewController[] controllers;

		public static GuildIconSelectPopup Create(GuildModel.ProfileIconData initIconData, Action<GuildModel.ProfileIconData> onEditDone)
		{
			return null;
		}

		public void OnIconSelect(GuildModel.ProfileIconData data)
		{
		}

		public void OnOKButtonPressed()
		{
		}
	}
}

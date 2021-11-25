using System;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class GuildIconTableViewCell : TableViewCell<GuildModel.ProfileIconData>
	{
		[Serializable]
		public class ButtonEvent : UnityEvent<GuildModel.ProfileIconData>
		{
		}

		[SerializeField]
		[Header("Info")]
		public CommonIcon icon;

		public ButtonEvent onCellPressed;

		[SerializeField]
		[Header("Selected")]
		public GameObject selectedFrame;

		public GuildIconSelectPopup popup;

		public override void UpdateContent(GuildModel.ProfileIconData data)
		{
		}

		public void OnIconPressed()
		{
		}
	}
}

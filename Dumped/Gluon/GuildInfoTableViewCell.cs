using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildInfoTableViewCell : TableViewCell<GuildInfoCellData>
	{
		[SerializeField]
		[Header("Emblem")]
		public RawImage emblemImage;

		[SerializeField]
		[Header("Approval")]
		public Image ribbonImage;

		public Sprite[] approvalRibbons;

		public Text[] approvalTexts;

		[SerializeField]
		[Header("Activity")]
		public Text[] activityTexts;

		[SerializeField]
		[Header("InfoTexts")]
		public Text populationText;

		public Text nameText;

		public Text mottoText;

		[SerializeField]
		[Header("Button")]
		public Button button;

		public const string prefabPath = "Prefabs/OutGame/Guild/GuildInfoTableViewCell";

		public Action<GuildInfoCellData> onCellPressed
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

		public Action<GuildInfoCellData> rejectAction
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

		public override void UpdateContent(GuildInfoCellData data)
		{
		}

		public void OnCellPressed()
		{
		}

		public void OnRejectButtonPressed()
		{
		}
	}
}

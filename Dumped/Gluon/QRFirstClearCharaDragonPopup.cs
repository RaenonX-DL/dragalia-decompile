using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QRFirstClearCharaDragonPopup : PopupBase
	{
		[SerializeField]
		public CommonIcon icon;

		public Text bottomText;

		public Text itemName;

		public Text itemRuby;

		[SerializeField]
		private Text title;

		private QuestResultModel.FirstClearModel.FirstClearItemInfo info;

		public bool isFromLoginBonus
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static QRFirstClearCharaDragonPopup Create(QuestResultModel.FirstClearModel.FirstClearItemInfo info, Action onOKOrClose, [Optional] Transform parentTransform)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public QuestResultModel.FirstClearModel.FirstClearItemInfo GetFirstClearItemInfo()
		{
			return null;
		}

		public void SetTitleText(string str)
		{
		}
	}
}

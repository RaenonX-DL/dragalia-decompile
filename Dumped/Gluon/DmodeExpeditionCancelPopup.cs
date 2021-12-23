using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeExpeditionCancelPopup : CommonPopup
	{
		[SerializeField]
		private Text floorNum;

		[SerializeField]
		private Text remainTime;

		private const string prefabPath = "Prefabs/OutGame/Dmode/DmodeExpeditionCancelPopup";

		public static DmodeExpeditionCancelPopup Create(Action onOK, Action onCancel)
		{
			return null;
		}

		private void SetText()
		{
		}

		public void OnUpdatePressed()
		{
		}
	}
}

using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultRetryConfirmPopup : CommonPopup
	{
		[SerializeField]
		private Text questItemTitle;

		[SerializeField]
		private Text questItemBefore;

		[SerializeField]
		private Text questItemAfter;

		[SerializeField]
		private GameObject questItemRoot;

		[SerializeField]
		private GameObject questStaminaRoot;

		[SerializeField]
		private Text staminaTitle;

		[SerializeField]
		private Text staminaBefore;

		[SerializeField]
		private Text staminaAfter;

		public static QuestResultRetryConfirmPopup Create(QuestDataElement qde, UnityAction onOkCallback, UnityAction onCancelCallback, bool showBlackLayer = true)
		{
			return null;
		}

		private void ReflectParam(QuestDataElement qde)
		{
		}

		public override void OnCancelButtonPressed()
		{
		}
	}
}

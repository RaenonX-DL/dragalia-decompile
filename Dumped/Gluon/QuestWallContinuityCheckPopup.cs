using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestWallContinuityCheckPopup : CommonPopup
	{
		[SerializeField]
		private Image questPreviewImage;

		[SerializeField]
		private Image questPreviewElement;

		[SerializeField]
		private Text questPreviewText;

		[SerializeField]
		private Text recommendText;

		[SerializeField]
		[Header("Limited Quest")]
		private Graphic limitedTypeBaseIcon;

		[SerializeField]
		private GameObject limitedTypeIconPanel;

		public static QuestWallContinuityCheckPopup Create(int wallId, [Optional] UnityAction OnOkCallback, [Optional] UnityAction OnCancelCallback)
		{
			return null;
		}

		public void SetContents(int wallId)
		{
		}

		private void SetLimitedType(int wallId)
		{
		}
	}
}

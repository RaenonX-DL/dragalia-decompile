using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CollectEventInfoCtrl : EventInfoCtrlBase
	{
		[SerializeField]
		private GameObject[] itemParent;

		[SerializeField]
		private Image[] itemIcon;

		[SerializeField]
		private Text[] itemCountText;

		[SerializeField]
		private Text hintText;

		[SerializeField]
		private Text hintTitleText;

		private const int usingCollectEventItemType = 1;

		public static CollectEventInfoCtrl Create(Transform parent)
		{
			return null;
		}

		public override void SetEventInfo()
		{
		}

		private void SetEventHintText()
		{
		}
	}
}

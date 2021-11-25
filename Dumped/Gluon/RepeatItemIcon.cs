using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class RepeatItemIcon : MonoBehaviour
	{
		[SerializeField]
		private CommonIcon commonIcon;

		[SerializeField]
		private GameObject selectingImage;

		private bool selecting;

		public ItemList item;

		private QuestRepeatPopup popup;

		public void Initilaize(ItemList item, QuestRepeatPopup popup)
		{
		}

		private void OnClick()
		{
		}

		public void Select()
		{
		}
	}
}

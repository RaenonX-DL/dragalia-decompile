using UnityEngine;

namespace Gluon
{
	public class SummonButton : MonoBehaviour
	{
		public SummonTopItemData.ButtonType buttonType;

		[HideInInspector]
		public SummonTopItemView itemView;

		[SerializeField]
		private GameObject priceText;

		private void Start()
		{
		}

		public void OnPress()
		{
		}

		public void SetInteractable(bool value)
		{
		}
	}
}

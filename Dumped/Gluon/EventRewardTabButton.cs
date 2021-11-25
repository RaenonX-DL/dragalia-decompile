using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventRewardTabButton : MonoBehaviour
	{
		[SerializeField]
		private Image normalImage;

		[SerializeField]
		private Image selectedImage;

		[SerializeField]
		private Text countText;

		[SerializeField]
		private Badge badge;

		public void SetContent(bool isSelected, int curIndex)
		{
		}
	}
}

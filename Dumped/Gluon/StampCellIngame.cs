using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class StampCellIngame : MonoBehaviour
	{
		[SerializeField]
		private Image stampImage;

		[SerializeField]
		private PointerEventHandler peh;

		private UnityAction<int> onIconPressed;

		public void Initialize(int stampId, UnityAction<int> action)
		{
		}

		public void OnIconPressed(int stampId)
		{
		}
	}
}

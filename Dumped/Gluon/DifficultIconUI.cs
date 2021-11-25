using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DifficultIconUI : MonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private Image iconImage;

		[SerializeField]
		[Header("parameter")]
		private Sprite[] elementSprites;

		public void SetImage(int elm)
		{
		}
	}
}

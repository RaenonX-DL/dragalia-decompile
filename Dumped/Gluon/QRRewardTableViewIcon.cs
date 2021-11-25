using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QRRewardTableViewIcon : MonoBehaviour
	{
		[SerializeField]
		public bool hasNumber;

		[SerializeField]
		public int number;

		[SerializeField]
		private Image numberBaseImage;

		[SerializeField]
		private Text numberText;

		private void Start()
		{
		}

		public void Reset()
		{
		}
	}
}

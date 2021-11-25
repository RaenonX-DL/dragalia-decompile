using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AbnormalStatusCell : MonoBehaviour
	{
		[SerializeField]
		private Image abnormalStatusImage;

		[SerializeField]
		private Text abnormalStatusText;

		public bool SetContents(AbnormalStatusType type)
		{
			return default(bool);
		}
	}
}

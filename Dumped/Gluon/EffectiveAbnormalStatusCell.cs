using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EffectiveAbnormalStatusCell : MonoBehaviour
	{
		[SerializeField]
		private Image effectiveAbnormalStatusImage;

		[SerializeField]
		private Text effectiveAbnormalStatusText;

		[SerializeField]
		private Image effectiveAbnormalStatus;

		public bool SetContents(AbnormalStatusType type, int registAbnormalRate)
		{
			return default(bool);
		}

		private Material GetRegistAbnormalRate(int rate)
		{
			return null;
		}
	}
}

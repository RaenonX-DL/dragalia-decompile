using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QRFirstMetPopup : QuestResultCommonPopup
	{
		[SerializeField]
		public CommonIcon icon;

		public Text bottomText;

		public static QRFirstMetPopup Create()
		{
			return null;
		}

		protected override void Start()
		{
		}
	}
}

using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeSellItemDonePopup : PopupBase
	{
		private static readonly string prefabPath;

		[SerializeField]
		[Header("Control")]
		private Text afterPointText;

		[SerializeField]
		private Text afterRarePointText;

		public static DmodeSellItemDonePopup Create()
		{
			return null;
		}

		protected override void Start()
		{
		}
	}
}

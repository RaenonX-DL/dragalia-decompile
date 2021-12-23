using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeChooseDragonRewardGetPointResultPopup : PopupBase
	{
		[SerializeField]
		[Header("Content")]
		public Text afterText;

		public static readonly string prefabPath;

		public static DmodeChooseDragonRewardGetPointResultPopup Create()
		{
			return null;
		}

		protected override void Start()
		{
		}
	}
}

using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeChooseDragonRewardGetPointConfirmPopup : PopupBase
	{
		[SerializeField]
		[Header("Content")]
		public Text beforeText;

		public Text afterText;

		public static readonly string prefabPath;

		public static DmodeChooseDragonRewardGetPointConfirmPopup Create()
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnOKButtonPressed()
		{
		}
	}
}

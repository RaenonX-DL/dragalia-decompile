using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UnitDetailAlbumProfilePopup : PopupBase
	{
		[SerializeField]
		private Text unitProfilelTitleText;

		[SerializeField]
		private Text unitProfilelText;

		public static UnitDetailAlbumProfilePopup Create()
		{
			return null;
		}

		protected override void Start()
		{
		}
	}
}

using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MatchingDeniedPopup : CommonPopup
	{
		[SerializeField]
		private CommonIcon currentPartyCharaIcon;

		[SerializeField]
		private Text requirePower;

		[SerializeField]
		private GameObject[] requireElements;

		[SerializeField]
		private GameObject requireWeaponRoot;

		[SerializeField]
		private GameObject[] requireWeapons;

		public static MatchingDeniedPopup Create(GameObject parentObject, RoomList itemData)
		{
			return null;
		}

		private void Initialize(RoomList itemData)
		{
		}
	}
}

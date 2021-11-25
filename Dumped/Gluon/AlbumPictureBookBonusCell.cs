using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumPictureBookBonusCell : MonoBehaviour
	{
		[SerializeField]
		private Image icon;

		[SerializeField]
		private Text facilityName;

		[SerializeField]
		private FacilityDialogContent facilityDialogContent;

		public void SetContentElementChara(AtgenElementBonus elementParam)
		{
		}

		public void SetContentElementDragon(AtgenElementBonus elementParam)
		{
		}

		private void LoadIconPrefab(string path)
		{
		}
	}
}

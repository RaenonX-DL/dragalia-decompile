using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeUnifiedAbilityCell : MonoBehaviour
	{
		[SerializeField]
		[Header("Content")]
		public RawImage icon;

		public Text nameText;

		public GameObject normalBG;

		public GameObject dragonBG;

		private DmodePopupUtil.DmodeUnifiedActiveAbilityInfo info;

		public void Setup(DmodePopupUtil.DmodeUnifiedActiveAbilityInfo info)
		{
		}

		public void OnPressed()
		{
		}
	}
}

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class LimitBreakMaterialListBase : CommonIconListBase
	{
		public UnityAction cancelButtonCallBack;

		public UnityAction limitBreakButtonCallBack;

		public Text listTitleText;

		public Button limitBreakButton;

		public Image limitBreakButtonImage;

		public Sprite buttonOnSprite;

		public Material buttonOnMaterial;

		public Sprite buttonOffSprite;

		public Material buttonOffMaterial;

		public GameObject effectBlackObj;

		[SerializeField]
		private Text limitBreakText;

		private void Start()
		{
		}

		public void CancelButtonPressed()
		{
		}

		public void limitBreakButtonPressed()
		{
		}

		public void limitBreakButtonLock()
		{
		}

		public void limitBreakButtonUnLock()
		{
		}
	}
}

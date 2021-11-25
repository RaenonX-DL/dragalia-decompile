using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ReleaseEquipSkillPopup : CommonPopup
	{
		[SerializeField]
		private Text charaLevelCountText;

		[SerializeField]
		private Text manaCircleCountText;

		[SerializeField]
		private GameObject materialBaseObject;

		[SerializeField]
		private Image materialIcon;

		[SerializeField]
		private Text materialNameText;

		[SerializeField]
		private Text materialCountText;

		[SerializeField]
		private GameObject errorTextObject;

		private int targetCharaId;

		public static ReleaseEquipSkillPopup Create()
		{
			return null;
		}

		public void SetupPopup(int targetCharaId)
		{
		}

		public void OnCharaLevelPressed()
		{
		}

		public void OnManaCirclePressed()
		{
		}

		public void OnMaterialIconPressed()
		{
		}

		public void OnMaterialIconLongPressed()
		{
		}

		public void ShowGoOtherSceneComfirmPopup(string showTextStr, Action okCallBack)
		{
		}
	}
}

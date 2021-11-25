using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CampaignImageSetting : MonoBehaviour
	{
		public Image singleImageViewImage;

		public GameObject campaignComment;

		public Text commentText;

		public SummonButton campaignButton;

		public Image campaignButtonNormalImage;

		public Image campaignButtonSelectedImage;

		public Image topBannerImage;

		public Text remainCountText;

		public GameObject remainCountBalloon;

		[SerializeField]
		private Image topActivePeriodImage;

		[SerializeField]
		private Text topActivePeriodText;

		[SerializeField]
		[Header("CSSummon")]
		public Button switchSummonButton;

		public Sprite[] switchSummonButtonImages;

		public Action onSwitchSummon;

		public void Setup(SummonTopItemData topData)
		{
		}

		private void SetImage(string assetsPath, Image image, string pathTemplate)
		{
		}

		private string GenerateScheduleText(int summonId)
		{
			return null;
		}

		public void OnSwitchSummonPressed()
		{
		}
	}
}

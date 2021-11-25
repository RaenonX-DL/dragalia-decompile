using System;
using System.Collections;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ExcludeImageSetting : MonoBehaviour
	{
		public Image singleImageViewImage;

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

		public FlashPlayerManager flashPlayerManager;

		private int summonId;

		private FlRoot kirakir;

		[SerializeField]
		[Header("CSSummon")]
		public Button switchSummonButton;

		public Sprite[] switchSummonButtonImages;

		public Action onSwitchSummon;

		private readonly string[] flashPaths;

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

		private IEnumerator PlayKiraCorutine()
		{
			return null;
		}

		public void OnSwitchSummonPressed()
		{
		}
	}
}

using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TipsObject : MonoBehaviour
	{
		public RubySupportedText text;

		public RubySupportedText fadeText;

		public Text captionText;

		public Text fadeCaptionText;

		public Image image;

		public Image fadeImage;

		public Image frameTipsImage;

		private const string formatFrameTips = "Frame_01_Tips_{0}";

		public Image ttlBgTipsImage;

		private const string formatTtlBgTips = "Others_Ttl_Bg_Tips_{0}";

		public Image titleBgImage;

		private const string formatTitleBg = "Others_Title_01_Bg_{0}";

		public UIAnimationBase ttlBgTipsAnimation;

		public UIAnimationBase titleBgAnimation;

		public void SetDefault()
		{
		}

		private void SetDefaultImage(Image image)
		{
		}

		public void SetThemeColorImages()
		{
		}

		private void ResetSwitcher(Image image)
		{
		}

		private void OnDestroy()
		{
		}

		private void DestroyImage(Image image)
		{
		}
	}
}

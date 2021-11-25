using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SummonSsrUpdateImageSetting : MonoBehaviour
	{
		[SerializeField]
		public Image singleImageViewImage;

		[SerializeField]
		public GameObject startDashComment;

		[SerializeField]
		public SummonButton startDashButton;

		[SerializeField]
		public Image topBannerImage;

		[SerializeField]
		public Image summonButtonNormalImage;

		[SerializeField]
		public Image summonButtonSelectedImage;

		public static readonly int resourceCharaSsrId;

		public static readonly int resourceDragonSsrId;

		public void Setup(SummonTopItemData topData)
		{
		}

		private void SetImage(string assetsPath, Image image, string pathTemplate)
		{
		}
	}
}

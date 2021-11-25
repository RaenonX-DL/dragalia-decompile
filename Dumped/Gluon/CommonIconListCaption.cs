using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonIconListCaption : MonoBehaviour
	{
		public class CaptionInfo
		{
			public string title;

			public int count;

			public int ability;

			public CaptionInfo()
			{
			}

			public CaptionInfo(string title, int count, int ability)
			{
			}
		}

		public const string prefabPath = "Prefabs/OutGame/Common/CommonIconListCaption";

		[SerializeField]
		public Image abilityIcon;

		public Text titleText;

		public Text countText;

		public static float captionHeight;

		public void Setup(string title, int count, int abilityId)
		{
		}
	}
}

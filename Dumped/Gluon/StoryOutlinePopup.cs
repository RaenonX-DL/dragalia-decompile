using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StoryOutlinePopup : CommonPopup
	{
		private const string prefabPath = "Prefabs/OutGame/Story/StoryOutlinePopup";

		[SerializeField]
		private RectTransform textRootRect;

		[SerializeField]
		private Text textBase;

		[SerializeField]
		private RectTransform textParentBase;

		private RectTransform[] textParents;

		private int lineMax;

		private int lineLetterMax;

		private string baseOutlineString;

		private int tempShowLetterNum;

		private float[] widths;

		private float rubyUpCoefficient;

		private float rubySizeCoefficient;

		public static StoryOutlinePopup Create()
		{
			return null;
		}

		public void InitSetting()
		{
		}

		public void AddOutlineText(string outlineString, string rubyString, bool isEnd)
		{
		}

		public static void EndScript()
		{
		}
	}
}

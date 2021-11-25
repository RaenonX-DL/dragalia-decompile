using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StoryBookTextCanvas : MonoBehaviour
	{
		public Camera mainCamera;

		[SerializeField]
		private Canvas uiCanvas;

		[SerializeField]
		public Image backGround;

		[SerializeField]
		private Text textBase;

		[SerializeField]
		private RectTransform textRootRect;

		[SerializeField]
		private RectTransform textParentBase;

		private RectTransform[] textParents;

		private string[] textStrings;

		private float[] widths;

		public string baseString;

		private int lineLetterMax;

		private int lineMax;

		private int showLineNum;

		private int totalLetterNum;

		private int pageLetterNum;

		private const int defaultTextSize = 28;

		private static readonly Color defaultColor;

		public bool isFirst;

		public void SetCanvasData()
		{
		}

		public void SetDefault()
		{
		}

		public void AddText(string textString, [Optional] string rubyString)
		{
		}

		private void SetDefaultTexts()
		{
		}

		public void SetCentering()
		{
		}

		private void OnDestroy()
		{
		}
	}
}

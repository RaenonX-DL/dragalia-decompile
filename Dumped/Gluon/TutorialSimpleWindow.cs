using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TutorialSimpleWindow : MonoBehaviour
	{
		public enum Menu
		{
			MyPage,
			Growth,
			Party,
			Battle,
			Fort,
			Summon
		}

		[SerializeField]
		[Header("ã\u0083¡ã\u0083\u008bã\u0083¥ã\u0083¼")]
		public Footer.MenuTab menuTab;

		[SerializeField]
		[TextArea]
		public string text;

		[SerializeField]
		protected Image frame;

		[SerializeField]
		protected Text title;

		[SerializeField]
		protected RubySupportedText textObj;

		protected Color whiteColor;

		protected Color blackColor;

		protected Color blackOutlineColor;

		protected float textWidthMargin;

		protected float textHeightMargin;

		protected float textPositionOffsetY;

		public static TutorialSimpleWindow CreateTutorialSimpleWindow(Canvas canvas)
		{
			return null;
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public void Close()
		{
		}

		public void SetTitleText(string str)
		{
		}

		public void SetTitleSize(Vector2 vec)
		{
		}

		public void SetText(string str)
		{
		}
	}
}

using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InquiryFaqBoxUI : MonoBehaviour
	{
		[SerializeField]
		private LayoutElement baseLayout;

		public Text titleText;

		public LayoutElement questionLayout;

		public Text questionText;

		public LayoutElement answerLayout;

		public Text answerText;

		public RectTransform innerBoxBase;

		public RectTransform outerBoxBase;

		public RectTransform arrowImageRect;

		public float moveTime;

		public int faqDataId;

		private bool isOpen;

		private bool isSendOpenMessage;

		private readonly float outerBoxCloseHeight;

		private readonly float outerBoxMerginHeight;

		private readonly float baseMerginHeight;

		public void OnButtonPressed()
		{
		}

		private void DOHeight(RectTransform rect, float endHeight, float moveTime)
		{
		}

		private void SendOpenMessage()
		{
		}
	}
}

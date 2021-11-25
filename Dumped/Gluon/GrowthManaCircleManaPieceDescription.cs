using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircleManaPieceDescription : MonoBehaviour
	{
		[SerializeField]
		private Text title;

		[SerializeField]
		private GameObject bgObject;

		[SerializeField]
		private Text subTitle;

		[SerializeField]
		private GameObject subBgObject;

		public CanvasGroup canvasGroup;

		public RectTransform rectTransform;

		public Sprite oneLineSprite;

		public Sprite secondLineSprite;

		private Image bgObjectImage;

		private Image subBgObjectImage;

		public void Awake()
		{
		}

		public void SetPosition(float x, float y)
		{
		}

		public void SetPositionOffset(float x, float y)
		{
		}

		public void SetTitleText(string str)
		{
		}

		public float GetTitleTextLength()
		{
			return default(float);
		}

		public void SetBgColor(Color color)
		{
		}

		public void SetSubTitleText(string str)
		{
		}

		public void SetTitleFontColor(Color color)
		{
		}

		public void SetAlpha(float alpha)
		{
		}

		public void SetScale(float scale)
		{
		}

		public void SetReleased(bool arg)
		{
		}

		public void SetTextFontSize(int size)
		{
		}

		public int GetTextFontSize()
		{
			return default(int);
		}
	}
}

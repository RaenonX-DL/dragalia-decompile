using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PagerUI : MonoBehaviour
	{
		[SerializeField]
		[Header("resource")]
		private Material material;

		[SerializeField]
		private Sprite offSprite;

		[SerializeField]
		private Sprite onSprite;

		[SerializeField]
		[Header("parameter")]
		private float margin;

		private int currentPage;

		private int maxPage;

		private Image[] images;

		public int CurrentPage
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public void Initialize(int max)
		{
		}

		private void SetPage(int value)
		{
		}
	}
}

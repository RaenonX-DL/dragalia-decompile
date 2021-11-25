using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class LimitStarBase : MonoBehaviour
	{
		public Image[] limitStars;

		public Sprite starOnSprite;

		public Sprite starOffSprite;

		public Material starMaterial;

		public Sprite starGrowSprite;

		public Sprite starCompleteSprite;

		public Sprite limitBreak5CompleteSprite;

		public Sprite limitBreak5InCompleteSprite;

		public Sprite limitBreak5GrowSprite;

		public void SetupLimitStar(int starCount, int growCount = 0, int maxLimitStar = 4)
		{
		}

		public void EnableStarImage(int starIndex, bool enable)
		{
		}

		public void ShowMaxLimitStar(int index)
		{
		}
	}
}

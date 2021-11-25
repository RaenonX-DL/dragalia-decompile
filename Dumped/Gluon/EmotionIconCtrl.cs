using UnityEngine;

namespace Gluon
{
	public class EmotionIconCtrl : MonoBehaviour
	{
		private const int maxIcon = 8;

		private int indexIcon;

		private EmotionIcon[] emotionIcons;

		public static EmotionIconCtrl Create(InGameUICtrl inGameUI, GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(InGameUICtrl inGameUI)
		{
		}

		public void Display(CharacterBase chara, EmotionIcon.Icon icon, EmotionIcon.Balloon balloon, float scale, float posY = 0f)
		{
		}

		public void StopAll()
		{
		}
	}
}

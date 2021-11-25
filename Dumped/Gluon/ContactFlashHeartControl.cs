using System;
using UnityEngine;

namespace Gluon
{
	public class ContactFlashHeartControl : MonoBehaviour
	{
		public enum HeartCountType
		{
			Three,
			Four,
			Six
		}

		private class SingleHeartSetting
		{
			public int carryingReliability;
		}

		private const string singleHeartEmotionPath = "Prefabs/OutGame/DragonContact/FlashEffect/pf_dragon_emotion_note_1";

		private const string FourHeartEmotionPath = "Prefabs/OutGame/DragonContact/FlashEffect/pf_dragon_emotion_note_2";

		private const string SixHeartEmotionPath = "Prefabs/OutGame/DragonContact/FlashEffect/pf_dragon_emotion_note_3";

		private FlashPlayer flashPlayer;

		private int containingHeartCount;

		private ContactReliabilitySlider reliabilitySlider;

		private int arrivalCount;

		private SingleHeartSetting[] hearSettings;

		private int carry;

		private Action<int> onAllCompleted;

		private int targetLevel;

		private Action onTargetHitByAnyHeart;

		private bool motionKilled;

		private const int cameraReturnTimingIndex = 3;

		private void OnHeartArrive(int index)
		{
		}

		public void Setup(FlashPlayerManager flashPlayerManager, HeartCountType type, Transform attachTo, ContactReliabilitySlider reliabilitySlider)
		{
		}

		public void PlayEffect(int carry, Action<int> onAllCompleted, int targetLevel, Action onTargetHitByAnyHeart)
		{
		}

		public void Stop()
		{
		}
	}
}

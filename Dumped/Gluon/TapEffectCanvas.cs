using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class TapEffectCanvas : SingletonInBaseMonoBehaviour<TapEffectCanvas>
	{
		public LongTapParameter longTapParameter;

		public TapEffect tapEffect;

		public TapEffect bigTapEffect;

		public LongTapTrail longTapTrail;

		public LongTapParticle longTapParticle;

		public RectTransform longTapTop;

		public RectTransform canvasRectTransform;

		public bool isBigEffect;

		public Sprite[] midSprite;

		public Sprite[] bigSprite;

		public Material[] midMaterial;

		public Material[] bigMaterial;

		private int longTapCount;

		private int longTapStopCount;

		private float lastTouchPositionX;

		private float lastTouchPositionY;

		private const int longTapCountThreashold = 5;

		private bool isLoaded;

		private IEnumerator Start()
		{
			return null;
		}

		private void LateUpdate()
		{
		}

		private void GetTouchPositionInCanvas(out float x, out float y)
		{
		}

		private IEnumerator PlayTapEffectCoroutine()
		{
			return null;
		}

		public void PlayBigTapEffect()
		{
		}

		public void Hide()
		{
		}
	}
}

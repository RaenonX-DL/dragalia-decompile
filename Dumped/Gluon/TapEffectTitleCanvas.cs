using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class TapEffectTitleCanvas : SingletonMonoBehaviour<TapEffectTitleCanvas>
	{
		public bool showEffect;

		public TapEffectTitle tapEffect;

		public TapEffectTitle bigTapEffect;

		public RectTransform canvasRectTransform;

		public bool isBigEffect;

		public Sprite[] midSprite;

		public Sprite[] bigSprite;

		public Material[] midMaterial;

		public Material[] bigMaterial;

		private bool isInitalized;

		protected override void Awake()
		{
		}

		private IEnumerator InitalizeCoroutine()
		{
			return null;
		}

		private void LateUpdate()
		{
		}

		public void DoNothing()
		{
		}

		private IEnumerator PlayTapEffectCoroutine()
		{
			return null;
		}

		public void PlayBigTapEffect()
		{
		}
	}
}

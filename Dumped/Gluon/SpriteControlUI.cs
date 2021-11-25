using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SpriteControlUI : MonoBehaviour
	{
		[SerializeField]
		[Header("resource")]
		private Sprite[] sprites;

		private int numSprite;

		private int indexSprite;

		private Image image;

		private RectTransform imageRt;

		private Tweener tweener;

		private Action<SpriteControlUI> func;

		private Vector2[] sizeSprite;

		public void Initialize()
		{
		}

		public void Play(float t, [Optional] Action<SpriteControlUI> func, Ease ease = Ease.Linear)
		{
		}

		private void OnUpdateSprite(float value)
		{
		}

		private void OnCompleteSprite()
		{
		}
	}
}

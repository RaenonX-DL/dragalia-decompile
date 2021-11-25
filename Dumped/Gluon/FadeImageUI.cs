using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FadeImageUI : MonoBehaviour
	{
		public enum Type
		{
			FadeIn,
			FadeOut,
			FadeInOut
		}

		public class Param
		{
			public Type type;

			public float fadeInTime;

			public float stayTime;

			public float fadeOutTime;

			public Color color;

			public Sprite sprite;

			public Action<FadeImageUI> endFunc;

			public float delay;

			public void Replicate(Param other)
			{
			}
		}

		[SerializeField]
		private Image image;

		[SerializeField]
		private float defaultFadeInTime;

		[SerializeField]
		private float defaultStayTime;

		[SerializeField]
		private float defaultFadeOutTime;

		private Color color;

		private Action<FadeImageUI> endFunc;

		private GameObject go;

		private Sprite whiteSprite;

		private Tweener tweener;

		private Param storeParam;

		private int proc;

		private const int bIn = 1;

		private const int bStay = 2;

		private const int bOut = 4;

		public Color GetColor()
		{
			return default(Color);
		}

		public static FadeImageUI Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public bool IsActive()
		{
			return default(bool);
		}

		public void Inactive()
		{
		}

		public void SetActive()
		{
		}

		public void Play(Param param)
		{
		}

		private void FadeOut(int f)
		{
		}

		private void OnUpdateFade(float value)
		{
		}

		private void OnCompleteFadeIn()
		{
		}

		private void OnCompleteFadeOut()
		{
		}
	}
}

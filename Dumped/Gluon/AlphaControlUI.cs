using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AlphaControlUI : MonoBehaviour
	{
		public enum Mode
		{
			UpdateCanvasGroup,
			UpdateGraphicColor
		}

		[SerializeField]
		[Header("parameter")]
		private Mode mode;

		private CanvasGroup canvasGroupCompo;

		private Graphic graphicCompo;

		private Tweener tweener;

		private Action<AlphaControlUI> func;

		public void Initialize()
		{
		}

		public void Alpha(float startAlpha, float endAlpha, Ease ease, float t, float delay, [Optional] Action<AlphaControlUI> func)
		{
		}

		public void SetAction(Action<AlphaControlUI> func)
		{
		}

		private void OnUpdateAlpha(float value)
		{
		}

		private void OnCompleteAlpha()
		{
		}
	}
}

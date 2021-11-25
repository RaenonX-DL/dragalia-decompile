using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class ScaleControlUI : MonoBehaviour
	{
		private RectTransform rt;

		private Tweener tweener;

		private Action<ScaleControlUI> func;

		private Vector2 fromScale;

		private Vector2 toScale;

		public void Initialize()
		{
		}

		public void Scale(Vector2 startScale, Vector2 endScale, Ease ease, float t, float delay, [Optional] Action<ScaleControlUI> func)
		{
		}

		private void OnUpdateScale(float value)
		{
		}

		private void OnCompleteScale()
		{
		}
	}
}

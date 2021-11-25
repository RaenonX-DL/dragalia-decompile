using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class BackButton : Button
	{
		private static readonly Vector3 initPosition;

		private static readonly Vector3 initPositionWithoutFooter;

		private const int imageGraphicGroupIndex = 0;

		private const int textGraphicGroupIndex = 1;

		private SimpleAnimationButton simpleAnimationButton;

		public static BackButton Create(Canvas canvas, UnityAction prevAction, SceneBase scene, bool isFromEventPage = false)
		{
			return null;
		}

		protected override void Awake()
		{
		}

		public void SetAutoExitAnimationEnabled(bool enable)
		{
		}

		public void ForceStartEnterAnimation([Optional] Action onAnimationDone)
		{
		}

		public void ForceStartExitAnimation([Optional] Action onAnimationDone)
		{
		}

		public void ExchangeBackButtonImageToText(string text, bool isCrossfading)
		{
		}

		private IEnumerator DelayExchangeBackButtonImageToText(string text, bool isCrossfading)
		{
			return null;
		}

		public void ExchangeBackButtonTextToImage(bool isCrossfading)
		{
		}
	}
}

using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonTabButtonBase : MonoBehaviour
	{
		private PointerEventHandler eventHandler;

		private Button button;

		private Color onTextColor;

		private Color offTextColor;

		private Animator buttonAnimator;

		private bool bDisabled;

		[SerializeField]
		private Text[] texts;

		private int index;

		public void Awake()
		{
		}

		private void TryGetComponents()
		{
		}

		public void SetIndex(int index)
		{
		}

		public void SetOnOffSprites(Sprite onSprite, Sprite offSprite)
		{
		}

		public void SetTextColors(Color onColor, Color offColor)
		{
		}

		public void AddCallback(Action<int, bool> callback)
		{
		}

		public void SwitchTextColor(bool on)
		{
		}

		public void SetOnOffState(bool on)
		{
		}

		public void DisableButton(bool disabled)
		{
		}
	}
}

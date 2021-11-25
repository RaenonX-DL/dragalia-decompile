using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ContinueConfirmDialog : InGameDialogBase
	{
		public class Param
		{
			public bool isCrystal;

			public Action<ContinueConfirmDialog> firstButtonFunction;

			public Action<ContinueConfirmDialog> secondButtonFunction;
		}

		[SerializeField]
		[Header("components")]
		protected RectTransform head;

		[SerializeField]
		protected RectTransform frameRt;

		[SerializeField]
		protected RectTransform textRt;

		[SerializeField]
		protected RectTransform textDescRt;

		[SerializeField]
		protected Image frame;

		[SerializeField]
		protected Text title;

		[SerializeField]
		protected Text text;

		[SerializeField]
		protected Image icon;

		[SerializeField]
		private Sprite _stoneIcon;

		[SerializeField]
		protected Sprite _diaIcon;

		[SerializeField]
		protected GameObject buttonBase;

		[SerializeField]
		protected Text firstButtonText;

		[SerializeField]
		protected Text secondButtonText;

		[SerializeField]
		protected Text nowNumText;

		[SerializeField]
		protected Text nextNumText;

		[SerializeField]
		protected Button firstButton;

		[SerializeField]
		protected Button secondButton;

		protected Action<ContinueConfirmDialog> firstButtonFunction;

		protected Action<ContinueConfirmDialog> secondButtonFunction;

		private RectTransform rootRt;

		private const float limitTextPosY = 121.8f;

		private const float unlimitTextPosY = 90f;

		public static ContinueConfirmDialog Create(GameObject parent)
		{
			return null;
		}

		protected virtual void Initialize()
		{
		}

		public void Open(Param param)
		{
		}

		public void Close()
		{
		}

		private void OnClose()
		{
		}

		public void Release()
		{
		}

		public void OnFirstButtonPressed()
		{
		}

		private void ExecFirstButtonPressed()
		{
		}

		public void OnSecondButtonPressed()
		{
		}

		private bool IsEnablePress()
		{
			return default(bool);
		}

		private void SetEnableButtons(bool b)
		{
		}
	}
}

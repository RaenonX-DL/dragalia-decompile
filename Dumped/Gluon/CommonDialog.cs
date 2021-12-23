using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonDialog : InGameDialogBase
	{
		public enum Size
		{
			S,
			M,
			L,
			CUSTOM
		}

		public enum BottomButtons
		{
			None,
			One,
			Two
		}

		public class Param
		{
			private const float defaultCustomHeight = 369f;

			private const int defaultTextFontSize = 24;

			public bool modal;

			public bool raycast;

			public Size size;

			public float customHeight;

			public BottomButtons bottomButtons;

			public string title;

			public string text;

			public int textFontSize;

			public TextAnchor textAnchor;

			public string firstButtonLabel;

			public string secondButtonLabel;

			public bool firstButtonPressedDialogClose;

			public bool secondButtonPressedDialogClose;

			public bool firstButtonInteractable;

			public bool secondButtonInteractable;

			public bool firstButtonPressedInteractable;

			public bool secondButtonPressedInteractable;

			public Action<CommonDialog> firstButtonFunction;

			public Action<CommonDialog> secondButtonFunction;

			public Action<CommonDialog> closedFunction;

			public Func<CommonDialog, bool> firstButtonInteractableFunction;

			public Func<CommonDialog, bool> secondButtonInteractableFunction;

			public void Clear()
			{
			}
		}

		[SerializeField]
		[Header("components")]
		protected RectTransform head;

		[SerializeField]
		protected RectTransform frameRt;

		[SerializeField]
		protected Image frame;

		[SerializeField]
		protected Text title;

		[SerializeField]
		protected Text textObj;

		[SerializeField]
		protected GameObject buttonBase;

		[SerializeField]
		protected Text firstButtonText;

		[SerializeField]
		protected Text secondButtonText;

		[SerializeField]
		protected Button firstButton;

		[SerializeField]
		protected Button secondButton;

		protected RectTransform rootRt;

		protected float firstButtonX;

		protected bool firstButtonDialogClose;

		protected bool secondButtonDialogClose;

		protected bool firstButtonInteractable;

		protected bool secondButtonInteractable;

		protected Action<CommonDialog> firstButtonFunction;

		protected Action<CommonDialog> secondButtonFunction;

		protected Action<CommonDialog> closedFunction;

		protected Func<CommonDialog, bool> firstButtonInteractableFunction;

		protected Func<CommonDialog, bool> secondButtonInteractableFunction;

		protected bool firstButtonInteractableDisabled;

		protected bool secondButtonInteractableDisabled;

		private int backKeyEventId;

		private static int backKeyEventCount;

		protected const float textWidthMargin = 60f;

		protected const float textHeightMargin = 150f;

		public static CommonDialog Create(GameObject parent)
		{
			return null;
		}

		protected virtual void Initialize()
		{
		}

		public void Update()
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

		private void OnRelease()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetText(string str)
		{
		}

		private void InitFrameSize(Param param)
		{
		}

		private void InitTextArea(float width, float height)
		{
		}

		private void InitBottomButtons(Param param)
		{
		}

		protected void SetRaycastTarget(bool b)
		{
		}

		public void OnFirstButtonPressed()
		{
		}

		protected virtual void ExecFirstButtonPressed()
		{
		}

		public void OnSecondButtonPressed()
		{
		}

		protected override void SetEnableButtons(bool b)
		{
		}
	}
}

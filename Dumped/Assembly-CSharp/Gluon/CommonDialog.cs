/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonDialog : InGameDialogBase
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform head;
		[SerializeField]
		protected RectTransform frameRt;
		[SerializeField]
		protected Image frame;
		[SerializeField]
		protected UnityEngine.UI.Text title;
		[SerializeField]
		protected UnityEngine.UI.Text textObj;
		[SerializeField]
		protected GameObject buttonBase;
		[SerializeField]
		protected UnityEngine.UI.Text firstButtonText;
		[SerializeField]
		protected UnityEngine.UI.Text secondButtonText;
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
	
		// Nested types
		public enum Size
		{
			S = 0,
			M = 1,
			L = 2,
			CUSTOM = 3
		}
	
		public enum BottomButtons
		{
			None = 0,
			One = 1,
			Two = 2
		}
	
		public class Param
		{
			// Fields
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
	
			// Constructors
			public Param();
	
			// Methods
			public void Clear();
		}
	
		// Constructors
		public CommonDialog();
		static CommonDialog();
	
		// Methods
		public static CommonDialog Create(GameObject parent);
		protected virtual void Initialize();
		public void Update();
		public void Open(Param param);
		public void Close();
		private void OnClose();
		public void Release();
		private void OnRelease();
		private void OnDestroy();
		public void SetText(string str);
		private void InitFrameSize(Param param);
		private void InitTextArea(float width, float height);
		private void InitBottomButtons(Param param);
		protected void SetRaycastTarget(bool b);
		public void OnFirstButtonPressed();
		protected virtual void ExecFirstButtonPressed();
		public void OnSecondButtonPressed();
		protected bool IsEnablePress();
		protected void SetEnableButtons(bool b);
		[CompilerGenerated]
		private void _Initialize_b__31_0();
		[CompilerGenerated]
		private void _Open_b__33_0();
		[CompilerGenerated]
		private void _Close_b__34_0();
		[CompilerGenerated]
		private void _Release_b__36_0();
	}
}

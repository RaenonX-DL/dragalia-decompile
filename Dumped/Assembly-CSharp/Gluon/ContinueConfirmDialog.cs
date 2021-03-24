/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContinueConfirmDialog : InGameDialogBase
	{
		// Fields
		[Header]
		[SerializeField]
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
		protected UnityEngine.UI.Text title;
		[SerializeField]
		protected UnityEngine.UI.Text text;
		[SerializeField]
		protected Image icon;
		[SerializeField]
		private Sprite _stoneIcon;
		[SerializeField]
		protected Sprite _diaIcon;
		[SerializeField]
		protected GameObject buttonBase;
		[SerializeField]
		protected UnityEngine.UI.Text firstButtonText;
		[SerializeField]
		protected UnityEngine.UI.Text secondButtonText;
		[SerializeField]
		protected UnityEngine.UI.Text nowNumText;
		[SerializeField]
		protected UnityEngine.UI.Text nextNumText;
		[SerializeField]
		protected Button firstButton;
		[SerializeField]
		protected Button secondButton;
		protected Action<ContinueConfirmDialog> firstButtonFunction;
		protected Action<ContinueConfirmDialog> secondButtonFunction;
		private RectTransform rootRt;
		private const float limitTextPosY = 121.8f;
		private const float unlimitTextPosY = 90f;
	
		// Nested types
		public class Param
		{
			// Fields
			public bool isCrystal;
			public Action<ContinueConfirmDialog> firstButtonFunction;
			public Action<ContinueConfirmDialog> secondButtonFunction;
	
			// Constructors
			public Param();
		}
	
		// Constructors
		public ContinueConfirmDialog();
	
		// Methods
		public static ContinueConfirmDialog Create(GameObject parent);
		protected virtual void Initialize();
		public void Open(Param param);
		public void Close();
		private void OnClose();
		public void Release();
		public void OnFirstButtonPressed();
		private void ExecFirstButtonPressed();
		public void OnSecondButtonPressed();
		private bool IsEnablePress();
		private void SetEnableButtons(bool b);
		[CompilerGenerated]
		private void _Initialize_b__24_0();
		[CompilerGenerated]
		private void _Open_b__25_0();
		[CompilerGenerated]
		private void _Close_b__26_0();
	}
}

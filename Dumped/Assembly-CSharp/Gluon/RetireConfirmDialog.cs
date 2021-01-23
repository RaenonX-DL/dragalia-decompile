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
	public class RetireConfirmDialog : InGameDialogBase
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform frameRt;
		[SerializeField]
		private GameObject buttonBase;
		[SerializeField]
		private UnityEngine.UI.Text cancelButtonText;
		[SerializeField]
		private UnityEngine.UI.Text okButtonText;
		[SerializeField]
		private Button cancelButton;
		[SerializeField]
		private Button okButton;
		[SerializeField]
		private UnityEngine.UI.Text title;
		[SerializeField]
		private UnityEngine.UI.Text detailText;
		[SerializeField]
		private UnityEngine.UI.Text manaNum;
		[SerializeField]
		private UnityEngine.UI.Text coinNum;
		[SerializeField]
		private UnityEngine.UI.Text[] itemText;
		[SerializeField]
		private Image frameImae;
		[SerializeField]
		private Image[] itemImage;
		[Header]
		[SerializeField]
		private Color32 selectedColor;
		private Action<RetireConfirmDialog> cancelButtonFunction;
		private Action<RetireConfirmDialog> okButtonFunction;
		private RectTransform rootRt;
		private bool isRetire;
		private CommonDialog commonDialog;
		private CommonDialog.Param commonDialogParam;
		private int backKeyEventId;
		private static int backKeyEventCount;
		private const int numKind = 2;
		private const int numItem = 6;
		private static readonly Vector2[] FrameLayout;
		private static readonly Vector2[] DetailTextLayout;
	
		// Nested types
		public enum Size
		{
			M = 0,
			L = 1
		}
	
		public class Param
		{
			// Fields
			public bool isRetire;
			public Size size;
			public string title;
			public string detail;
			public string okButtonText;
			public string cancelButtonText;
			public Action<RetireConfirmDialog> okButtonFunction;
			public Action<RetireConfirmDialog> cancelButtonFunction;
	
			// Constructors
			public Param();
	
			// Methods
			public void SetupRetryParam();
			public void SetupRetireParam();
		}
	
		// Constructors
		public RetireConfirmDialog();
		static RetireConfirmDialog();
	
		// Methods
		public static RetireConfirmDialog Create(GameObject parent);
		private void Initialize();
		public void Update();
		private void LoadEventSackMaterial(int type);
		public void Open(Param param);
		private void SetupLayout(Size type);
		public void Close(bool isPlayCloseSE = false);
		private void OnDestroy();
		private void UpdateItemCount(ref UnityEngine.UI.Text uiText, int count);
		public void OnCancelButtonPressed();
		private void ExecCancelButtonPressed();
		public void OnOkButtonPressed();
		public void OnCancelButtonPressedFromMultiConfirmDialog(CommonDialog dlg);
		public void OnOkButtonPressedFromMultiConfirmDialog(CommonDialog dlg);
		public bool IsOpenMultiConfirmationDialog();
		private bool IsEnablePress();
		private void SetEnableButtons(bool b);
		[CompilerGenerated]
		private void _Initialize_b__29_0();
		[CompilerGenerated]
		private void _Open_b__32_0();
		[CompilerGenerated]
		private void _Close_b__34_0();
	}
}

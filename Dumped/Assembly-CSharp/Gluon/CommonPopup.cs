/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public Footer.MenuTab menuTab;
		[Header]
		[SerializeField]
		public Size size;
		[Header]
		[SerializeField]
		public float customHeight;
		[Header]
		[SerializeField]
		public BottomButtons bottomButtons;
		[SerializeField]
		[TextArea]
		public string text;
		[SerializeField]
		public TextAnchor textAnchor;
		[SerializeField]
		public UnityEvent cancelButtonPressed;
		[SerializeField]
		public UnityEvent okButtonPressed;
		[SerializeField]
		protected Image frame;
		[SerializeField]
		protected UnityEngine.UI.Text title;
		[SerializeField]
		protected UnityEngine.UI.Text textObj;
		[SerializeField]
		protected Button cancelButton;
		[SerializeField]
		protected UnityEngine.UI.Text cancelText;
		[SerializeField]
		protected Button okButton;
		[SerializeField]
		protected UnityEngine.UI.Text okText;
		[SerializeField]
		protected Button closeButton;
		[SerializeField]
		protected UnityEngine.UI.Text closeText;
		[SerializeField]
		public RectTransform[] tableViews;
		protected Color whiteColor;
		protected Color blackColor;
		protected Color blackOutlineColor;
		protected float _textWidthMargin;
		protected float _textHeightMargin;
		protected float textPositionOffsetY;
	
		// Properties
		public float textWidthMargin { get; set; }
		public float textHeightMargin { get; set; }
	
		// Nested types
		public enum Menu
		{
			MyPage = 0,
			Growth = 1,
			Party = 2,
			Battle = 3,
			Fort = 4,
			Summon = 5
		}
	
		public enum Size
		{
			S = 0,
			M = 1,
			L = 2,
			CUSTOM = 3
		}
	
		public enum BottomButtons
		{
			Close = 0,
			CancelOk = 1,
			None = 2
		}
	
		// Constructors
		public CommonPopup();
	
		// Methods
		public static CommonPopup Create(Size size = Size.S, BottomButtons bottomButtons = BottomButtons.Close, bool showBlackLayer = true, bool showStartAnimation = true, bool isErrorPopupCanvas = false);
		public static CommonPopup Create(Size size, BottomButtons bottomButtons, bool showBlackLayer, bool showStartAnimation, bool isErrorPopupCanvas, bool isIndependentTime);
		public static CommonPopup CreateWithPrefabPath(string prefabPath, bool showBlackLayer = false, bool showStartAnimation = true, bool isErrorPopupCanvas = false);
		protected virtual void Awake();
		protected override void Start();
		public static Vector2 AdjustPopupFrameBySize(RectTransform frame, Size size, float customHeight = 0f);
		protected virtual void InitFrameSizeAndPosition();
		protected virtual void InitContentSize();
		private void InitTextArea(float width, float height);
		protected void InitBottomButtons();
		public virtual void OnCloseButtonPressed();
		public virtual void OnCancelButtonPressed();
		public virtual void OnOkButtonPressed();
		public void SetTitleText(string str);
		public void SetTitleSize(Vector2 vec);
		public virtual void SetText(string str);
		public void SetTextAnchor(TextAnchor anchor);
		public void SetEnableOkButton(bool arg);
		public void SetEnableCancelButton(bool arg);
		public void ChangeOkButtonText(string text);
		public void ChangeCancelButtonText(string text);
		public void ChangeCancelButtonSound(ButtonSound.SEType seType);
		public void ChangeCloseButtonText(string text);
		public void ChangeOkButtonMaintenanceTypes(List<MaintenanceFunctionType> maintenanceTypes);
		public void SetCurrentMenuTabForIndexing(UiImageExchanger.IndexReceiver indexReceiver);
		public Button GetOkButton();
		public Button GetCancelButton();
	}
}

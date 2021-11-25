using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonPopup : PopupBase
	{
		public enum Menu
		{
			MyPage,
			Growth,
			Party,
			Battle,
			Fort,
			Summon
		}

		public enum Size
		{
			S,
			M,
			L,
			CUSTOM
		}

		public enum BottomButtons
		{
			Close,
			CancelOk,
			None
		}

		[SerializeField]
		[Header("ã\u0083¡ã\u0083\u008bã\u0083¥ã\u0083¼")]
		public Footer.MenuTab menuTab;

		[SerializeField]
		[Header("ã\u0082µã\u0082¤ã\u0082ºã\u0082¿ã\u0082¤ã\u0083\u0097")]
		public Size size;

		[SerializeField]
		[Header("ã\u0082«ã\u0082¹ã\u0082¿ã\u0083\u00a0ã\u0081®å\u00a0\u00b4å\u0090\u0088ã\u0081®é«\u0098ã\u0081\u0095")]
		public float customHeight;

		[SerializeField]
		[Header("ã\u0083\u009cã\u0082¿ã\u0083³ã\u0081®ç\u00a8®é¡\u009e")]
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
		protected Text title;

		[SerializeField]
		protected Text textObj;

		[SerializeField]
		protected Button cancelButton;

		[SerializeField]
		protected Text cancelText;

		[SerializeField]
		protected Button okButton;

		[SerializeField]
		protected Text okText;

		[SerializeField]
		protected Button closeButton;

		[SerializeField]
		protected Text closeText;

		[SerializeField]
		public RectTransform[] tableViews;

		protected Color whiteColor;

		protected Color blackColor;

		protected Color blackOutlineColor;

		protected float _textWidthMargin;

		protected float _textHeightMargin;

		protected float textPositionOffsetY;

		public float textWidthMargin
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float textHeightMargin
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public static CommonPopup Create(Size size = Size.S, BottomButtons bottomButtons = BottomButtons.Close, bool showBlackLayer = true, bool showStartAnimation = true, bool isErrorPopupCanvas = false)
		{
			return null;
		}

		public static CommonPopup Create(Size size, BottomButtons bottomButtons, bool showBlackLayer, bool showStartAnimation, bool isErrorPopupCanvas, bool isIndependentTime)
		{
			return null;
		}

		public static CommonPopup CreateWithPrefabPath(string prefabPath, bool showBlackLayer = false, bool showStartAnimation = true, bool isErrorPopupCanvas = false)
		{
			return null;
		}

		protected virtual void Awake()
		{
		}

		protected override void Start()
		{
		}

		public static Vector2 AdjustPopupFrameBySize(RectTransform frame, Size size, float customHeight = 0f)
		{
			return default(Vector2);
		}

		protected virtual void InitFrameSizeAndPosition()
		{
		}

		protected virtual void InitContentSize()
		{
		}

		private void InitTextArea(float width, float height)
		{
		}

		protected void InitBottomButtons()
		{
		}

		public virtual void OnCloseButtonPressed()
		{
		}

		public virtual void OnCancelButtonPressed()
		{
		}

		public virtual void OnOkButtonPressed()
		{
		}

		public void SetTitleText(string str)
		{
		}

		public void SetTitleSize(Vector2 vec)
		{
		}

		public virtual void SetText(string str)
		{
		}

		public void SetTextAnchor(TextAnchor anchor)
		{
		}

		public void SetTextFontSize(int fontSize)
		{
		}

		public void SetEnableOkButton(bool arg)
		{
		}

		public void SetEnableCancelButton(bool arg)
		{
		}

		public void ChangeOkButtonText(string text)
		{
		}

		public void ChangeCancelButtonText(string text)
		{
		}

		public void ChangeCancelButtonSound(ButtonSound.SEType seType)
		{
		}

		public void ChangeCloseButtonText(string text)
		{
		}

		public void ChangeOkButtonMaintenanceTypes(List<MaintenanceFunctionType> maintenanceTypes)
		{
		}

		public void SetCurrentMenuTabForIndexing(UiImageExchanger.IndexReceiver indexReceiver)
		{
		}

		public Button GetOkButton()
		{
			return null;
		}

		public Button GetCancelButton()
		{
			return null;
		}
	}
}

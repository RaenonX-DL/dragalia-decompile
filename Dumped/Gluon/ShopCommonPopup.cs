using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class ShopCommonPopup : CommonPopup
	{
		protected Action onOKOrClose;

		protected Action onCancel;

		[SerializeField]
		[Header("PanelModeOnOffs")]
		protected GameObject[] dialogModeOnGOs;

		[SerializeField]
		protected GameObject[] panelModeOnGOs;

		[SerializeField]
		[Header("PanelModeFrameOffset")]
		protected float panelModeFrameSizeDiff;

		[SerializeField]
		protected Vector3 panelModeFrameOffset;

		protected Transform frameParent;

		private RectTransform referenceRect;

		protected bool isPanelMode
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static ShopCommonPopup Create(string title, string text, BottomButtons bottomButtons = BottomButtons.Close, [Optional] Action onOKOrClose, [Optional] Action onCancel, Size size = Size.S)
		{
			return null;
		}

		public static ShopCommonPopup CreateWithPrefab(string prefabName, [Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
			return null;
		}

		public void SetPanelMode(Transform frameParent, RectTransform referenceRect)
		{
		}

		public void SetCallbacks([Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
		}

		private void InitWithTitleAndText(string title, string text, [Optional] Action onOKOrClose, [Optional] Action onCancel)
		{
		}

		protected override void Start()
		{
		}

		protected virtual void OnPanelModeSet()
		{
		}

		protected virtual void OnOKOrClosePopup()
		{
		}

		protected virtual void OnCancelPopup()
		{
		}
	}
}

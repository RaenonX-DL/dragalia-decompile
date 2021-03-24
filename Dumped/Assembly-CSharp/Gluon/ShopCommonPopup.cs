/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopCommonPopup : CommonPopup
	{
		// Fields
		protected Action onOKOrClose;
		protected Action onCancel;
		[Header]
		[SerializeField]
		protected GameObject[] dialogModeOnGOs;
		[SerializeField]
		protected GameObject[] panelModeOnGOs;
		[Header]
		[SerializeField]
		protected float panelModeFrameSizeDiff;
		[SerializeField]
		protected Vector3 panelModeFrameOffset;
		[CompilerGenerated]
		private bool _isPanelMode_k__BackingField;
		protected Transform frameParent;
		private RectTransform referenceRect;
	
		// Properties
		protected bool isPanelMode { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public ShopCommonPopup();
	
		// Methods
		public static ShopCommonPopup Create(string title, string text, BottomButtons bottomButtons = BottomButtons.Close, Action onOKOrClose = null, Action onCancel = null, Size size = Size.S);
		public static ShopCommonPopup CreateWithPrefab(string prefabName, Action onOKOrClose = null, Action onCancel = null);
		public void SetPanelMode(Transform frameParent, RectTransform referenceRect);
		public void SetCallbacks(Action onOKOrClose = null, Action onCancel = null);
		private void InitWithTitleAndText(string title, string text, Action onOKOrClose = null, Action onCancel = null);
		protected override void Start();
		protected virtual void OnPanelModeSet();
		protected virtual void OnOKOrClosePopup();
		protected virtual void OnCancelPopup();
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultCommonPopup : CommonPopup
	{
		// Fields
		[Header]
		[SerializeField]
		protected AnimationUIAutoPublisher exitUIPublisher;
		protected Action onOKOrClose;
		protected Action onCancel;
	
		// Constructors
		public QuestResultCommonPopup();
	
		// Methods
		public static QuestResultCommonPopup Create(string title, string text, BottomButtons bottomButtons = BottomButtons.Close, Action onOKOrClose = null, Action onCancel = null);
		public static QuestResultCommonPopup CreateWithPrefab(string prefabName, Action onOKOrClose = null, Action onCancel = null);
		public void SetCallbacks(Action onOKOrClose = null, Action onCancel = null);
		private void InitWithTitleAndText(string title, string text, Action onOKOrClose = null, Action onCancel = null);
		protected override void Start();
		public virtual void OnOKOrClosePopup();
		public virtual void OnOKOrClosePopupWithSlideAnim();
		public virtual void OnCancelPopup();
		[CompilerGenerated]
		private void _OnOKOrClosePopupWithSlideAnim_b__9_0();
	}
}

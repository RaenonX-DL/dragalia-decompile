/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TotalDamageEventNotifiyReceivableRewardPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text descriptionText;
		[SerializeField]
		private Image eventLogoImage;
		private EventDataElement receivableRewardEventData;
		private UnityEvent okButtonPressed;
		private static bool isFinishedShowingPopup;
		private static readonly string notifiyReceivableRewardPopupPath;
		private static readonly string eventLogoPath;
		private static readonly Vector2 eventLogoSize;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<EventDataElement> __9__10_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _CreateNeedShowPopupEventList_b__10_0(EventDataElement a, EventDataElement b);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public UnityAction callback;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _AddOkButtonPressedCallback_b__0();
		}
	
		// Constructors
		public TotalDamageEventNotifiyReceivableRewardPopup();
		static TotalDamageEventNotifiyReceivableRewardPopup();
	
		// Methods
		public static TotalDamageEventNotifiyReceivableRewardPopup Create(EventDataElement eventData);
		private void Initialize();
		public static List<EventDataElement> CreateNeedShowPopupEventList();
		public void OkButtonPressed();
		public void AddOkButtonPressedCallback(UnityAction callback);
		[CompilerGenerated]
		private void _Initialize_b__9_0();
	}
}

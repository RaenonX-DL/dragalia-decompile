/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactUseItemPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private CommonIcon beforeIcon;
		[SerializeField]
		private CommonIcon afterIcon;
		[SerializeField]
		private CommonIcon itemIcon;
		[SerializeField]
		private UnityEngine.UI.Text itemName;
		[SerializeField]
		private UnityEngine.UI.Text ItemDescription;
		[SerializeField]
		private CommonSliderSelection slider;
		[SerializeField]
		private UnityEngine.UI.Text overText;
		[SerializeField]
		private float delayTimeIcon;
		[SerializeField]
		private float delayTimeShopPanel;
		private DragonStrokeMain dragonStrokeMain;
		private ContactGiftIcon targetIcon;
		private int currentLevel;
		private int afterLevel;
		private int maxLevel;
		private int currentValue;
		private int overValue;
		private int reliability;
		private int presentItemNum;
		private int dragonId;
		private const int presentItemMaxValue = 30;
		private bool isEalkerEventItem;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public UnityAction onClose;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public TouchGuardObject touchGuard;
			public ContactUseItemPopup __4__this;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _SendPresent_b__0();
		}
	
		// Constructors
		public ContactUseItemPopup();
	
		// Methods
		public static ContactUseItemPopup Create(UnityAction onClose, bool isEalkerEventItem);
		public void Setup(DragonStrokeMain dragonStroke, DragonGiftList dragonGift, ContactGiftIcon icon, bool isWalkEventItem);
		private void OnSlideValueChanged(float value);
		public void OnPressOk();
		private void SendPresent();
		public void ApiSendGiftMultiple();
		public void ApiOnSendGiftMultipleError(ErrorType errorType, int errorCode);
		private void ApiOnSendGiftMultipleSuccess(DragonSendGiftMultipleResponse res);
		public void ApiSendWalkerGiftMultiple();
		public void ApiOnSendWalkerGiftMultipleError(ErrorType errorType, int errorCode);
		private void ApiOnSendWalkerGiftMultipleSuccess(WalkerSendGiftMultipleResponse res);
		protected override void OnDestroy();
		[CompilerGenerated]
		private void _OnPressOk_b__24_0();
	}
}

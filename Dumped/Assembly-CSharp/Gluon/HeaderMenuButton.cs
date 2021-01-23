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
	public class HeaderMenuButton : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Badge menuBadge;
		[CompilerGenerated]
		private bool _isHavingUnreadComments_k__BackingField;
		public MenuPopup menuPopup;
		private DateTime lastCheckInquiryTime;
		private const int checkInquiryInterval = 1800000;
	
		// Properties
		public bool isHavingUnreadComments { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public HeaderMenuButton __4__this;
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _CheckInquiryStatus_b__0(bool isHavingUnreadComments, bool hasError);
		}
	
		// Constructors
		public HeaderMenuButton();
	
		// Methods
		public void OnButtonPressed();
		public void SetMenuBadge(bool isActive);
		public void UpdateMenuBadge();
		public void CheckInquiryStatus(bool checkTime = true, Action onComplete = null);
	}
}

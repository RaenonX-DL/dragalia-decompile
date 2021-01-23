/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventRewardPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private Image logoImage;
		[SerializeField]
		private EventRewardInfoCtrl eventInfo;
		[SerializeField]
		private EventRewardCtrl rewardCtrl;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public int cycleId;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal bool _SetContent_b__0(EventCyclePointRewardElement x);
		}
	
		// Constructors
		public EventRewardPopup();
	
		// Methods
		protected override void Start();
		public void UpdateReceiveButtonInformation();
		public void SetContent();
	}
}

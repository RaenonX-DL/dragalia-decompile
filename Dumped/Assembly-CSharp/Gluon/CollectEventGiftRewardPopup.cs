/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CollectEventGiftRewardPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private Transform iconParent;
		private List<CommonIcon> iconList;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text commentText;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public UnityAction onClose;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		// Constructors
		public CollectEventGiftRewardPopup();
	
		// Methods
		public static CollectEventGiftRewardPopup Create(UnityAction onClose);
		public void SetupEventStoryReward();
		private CommonIcon CreateIcon(AtgenBuildEventRewardEntityList reward);
		protected override void OnDestroy();
	}
}

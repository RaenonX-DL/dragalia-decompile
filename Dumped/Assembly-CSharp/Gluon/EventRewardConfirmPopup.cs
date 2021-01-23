/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventRewardConfirmPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text title;
		[SerializeField]
		private GameObject rewardObj;
		[SerializeField]
		private GameObject allRewardText;
		[SerializeField]
		private CommonIcon rewardIcon;
		[SerializeField]
		private UnityEngine.UI.Text rewardText;
	
		// Constructors
		public EventRewardConfirmPopup();
	
		// Methods
		public void Init(bool isAllReward, GiftType giftType = GiftType.NONE, int itemId = 0);
	}
}

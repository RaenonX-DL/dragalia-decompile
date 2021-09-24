/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TotalDamageEventRewardPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private Image logoImage;
		[SerializeField]
		private TotalDamageEventRewardInfoCtrl eventInfo;
		[SerializeField]
		private EventRewardCtrl rewardCtrl;
		[SerializeField]
		private UnityEngine.UI.Text sentPresentBoxText;
		[SerializeField]
		private GameObject eventEndDescription;
		public static readonly TimeSpan receiveRewardTimeSpan;
	
		// Constructors
		public TotalDamageEventRewardPopup();
		static TotalDamageEventRewardPopup();
	
		// Methods
		protected override void Start();
		private DateTime CalcReceiveRewardTime();
		public void ShowTotalDamageHistoryPopup();
		public void SetContent();
	}
}

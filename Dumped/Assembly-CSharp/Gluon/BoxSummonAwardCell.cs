/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BoxSummonAwardCell : TableViewCell<Gluon.EventRewardCellData>
	{
		// Fields
		[SerializeField]
		private CommonIcon icon;
		[SerializeField]
		private UnityEngine.UI.Text conditionText;
		[SerializeField]
		private UnityEngine.UI.Text nameText;
		[SerializeField]
		private Button receiptButton;
		[SerializeField]
		private Image pickupImage;
		[SerializeField]
		private Image haveReceivedImage;
		private int rewardId;
		private EventRewardCellData data;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__9_1;
			public static UnityAction __9__9_3;
			public static UnityAction __9__9_5;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnReceipButtonTouched_b__9_1();
			internal void _OnReceipButtonTouched_b__9_3();
			internal void _OnReceipButtonTouched_b__9_5();
		}
	
		// Constructors
		public BoxSummonAwardCell();
	
		// Methods
		public override void UpdateContent(EventRewardCellData itemData);
		public void OnReceipButtonTouched();
		public void UpdateCanReceiveInformation();
		private void SetGotState(bool hadGot);
		[CompilerGenerated]
		private void _OnReceipButtonTouched_b__9_0(RaidEventReceiveRaidPointRewardResponse response);
		[CompilerGenerated]
		private void _OnReceipButtonTouched_b__9_2(ExHunterEventReceiveExHunterPointRewardResponse response);
		[CompilerGenerated]
		private void _OnReceipButtonTouched_b__9_4(MazeEventReceiveMazePointRewardResponse response);
	}
}

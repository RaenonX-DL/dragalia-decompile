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
	public class TotalDamageEventRewardCell : TableViewCell<Gluon.EventRewardCellData>
	{
		// Fields
		[SerializeField]
		private CommonIcon icon;
		[SerializeField]
		private UnityEngine.UI.Text conditionText;
		[SerializeField]
		private UnityEngine.UI.Text nameText;
		[SerializeField]
		private Image pickupImage;
		[SerializeField]
		private Image haveReceivedImage;
		private int rewardId;
		private EventRewardCellData data;
	
		// Constructors
		public TotalDamageEventRewardCell();
	
		// Methods
		public override void UpdateContent(EventRewardCellData itemData);
		private void UpdateCanReceiveInformation();
		private void SetGotState(bool hadGot);
	}
}

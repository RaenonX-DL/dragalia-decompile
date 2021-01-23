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
	public class QuestEventRewardCell : TableViewCell<Gluon.QuestEventRewardCellData>
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
		private QuestEventRewardCellData data;
	
		// Constructors
		public QuestEventRewardCell();
	
		// Methods
		public override void UpdateContent(QuestEventRewardCellData itemData);
	}
}

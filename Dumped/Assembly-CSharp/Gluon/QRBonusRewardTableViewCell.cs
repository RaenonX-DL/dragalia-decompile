/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QRBonusRewardTableViewCell : TableViewCell<Gluon.QuestResultModel.QuestBonus.QuestBonusInfo>
	{
		// Fields
		[SerializeField]
		private CommonIcon icon;
		[SerializeField]
		private UnityEngine.UI.Text itemName;
		[SerializeField]
		private UnityEvent<int> buttonPressed;
	
		// Constructors
		public QRBonusRewardTableViewCell();
	
		// Methods
		public override void UpdateContent(QuestResultModel.QuestBonus.QuestBonusInfo data);
	}
}

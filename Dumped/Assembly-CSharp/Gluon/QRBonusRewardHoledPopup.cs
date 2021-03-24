/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QRBonusRewardHoledPopup : QuestResultCommonPopup
	{
		// Fields
		[SerializeField]
		private QRBonusRewardTableViewController questRewardTableViewController;
		[SerializeField]
		private GameObject bonusPlusImage;
		private QuestResultModel.QuestBonus model;
	
		// Constructors
		public QRBonusRewardHoledPopup();
	
		// Methods
		public static QRBonusRewardHoledPopup Create(Action onOKOrClose = null, Action onCancel = null);
		public static QRBonusRewardHoledPopup CreateWithModel(QuestResultModel.QuestBonus model, Action onOKOrClose = null, Action onCancel = null);
		public static QRBonusRewardHoledPopup Create(List<QuestResultModel.QuestBonus.QuestBonusInfo> list, string title, string mainText, Action onOKOrClose = null, Action onCancel = null);
		public void SetBonusPlusImage();
	}
}

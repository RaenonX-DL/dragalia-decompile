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
	public class QuestInstructorBonusDetailTargetRewardCell : TableViewCell<Gluon.QuestInstructorBonusDetailTargetReward>
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text questName;
		[SerializeField]
		private UnityEngine.UI.Text questLastCount;
		[SerializeField]
		private GameObject[] stampBox;
		[SerializeField]
		private Image[] stampImage;
	
		// Constructors
		public QuestInstructorBonusDetailTargetRewardCell();
	
		// Methods
		public override void UpdateContent(QuestInstructorBonusDetailTargetReward data);
	}
}

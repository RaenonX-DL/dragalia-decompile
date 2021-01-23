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
	public class QuestResultRankUpRewardCell : TableViewCell<Gluon.QuestResultModel.PlayerLevelupModel.PlantEnhanceInfo>
	{
		// Fields
		[SerializeField]
		public Image icon;
		public UnityEngine.UI.Text title;
		[SerializeField]
		private Image gridImage;
		[SerializeField]
		private QuestStateIcon newIcon;
		[SerializeField]
		private QuestResultRankUpReward firstReward;
		[SerializeField]
		private QuestResultRankUpReward secondReward;
	
		// Constructors
		public QuestResultRankUpRewardCell();
	
		// Methods
		public override void UpdateContent(QuestResultModel.PlayerLevelupModel.PlantEnhanceInfo data);
	}
}

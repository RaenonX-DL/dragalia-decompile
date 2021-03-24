/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultRankUpRewardController : TableViewController<Gluon.QuestResultModel.PlayerLevelupModel.PlantEnhanceInfo>
	{
		// Fields
		private float cellHeight;
		private float cellWidth;
	
		// Constructors
		public QuestResultRankUpRewardController();
	
		// Methods
		protected override void Awake();
		public void LoadData();
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		public Sequence FadeIn();
	}
}

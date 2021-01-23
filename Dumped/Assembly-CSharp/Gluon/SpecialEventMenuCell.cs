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
	public class SpecialEventMenuCell : EventMenuCell
	{
		// Fields
		[SerializeField]
		private Image ribbonRaidImage;
		[SerializeField]
		private Image ribbonSpecialRaidImage;
		[SerializeField]
		private Image ribbonBuildImage;
		[SerializeField]
		private Image ribbonStoryImage;
		[SerializeField]
		private Image ribbonCombatImage;
		[SerializeField]
		private Image ribbonDefenceImage;
		[SerializeField]
		private Image ribbonArenaImage;
		[SerializeField]
		private Image ribbonTrainingImage;
		[SerializeField]
		private Image battleRoyalAvailableImage;
	
		// Nested types
		private enum QuestRibbonImageType
		{
			None = 0,
			Raid = 20401,
			Build = 20801,
			Story = 21301,
			Combat = 22201,
			Defence = 22202,
			Arena = 22203,
			Training = 31001
		}
	
		// Constructors
		public SpecialEventMenuCell();
	
		// Methods
		public override void SetContent(QuestSelectInstance.QuestEventData eventData, bool isShowArrow, FlashPlayerManager flashPlayerManager);
		public override void OnCellTouched();
		[CompilerGenerated]
		private void _OnCellTouched_b__11_0();
	}
}

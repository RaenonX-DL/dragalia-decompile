using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class BattleRoyalSelectJobSkinPage : EventQuestPageBase
	{
		public RectTransform layoutParent;

		public BattleRoyalJobCell templateCell;

		private Dictionary<WeaponType, BattleRoyalJobCell> cellList;

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		private void OnDecided(WeaponType wt, bool isValid)
		{
		}

		private void OnBackButtonTouched()
		{
		}
	}
}

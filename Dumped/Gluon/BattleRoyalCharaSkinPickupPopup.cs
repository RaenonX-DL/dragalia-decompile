using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class BattleRoyalCharaSkinPickupPopup : CommonPopup
	{
		public GameObject originCell;

		public Transform cellParentTransform;

		private List<BattleRoyalCharaSkinPickupListCell> listCells;

		public static BattleRoyalCharaSkinPickupPopup Create()
		{
			return null;
		}

		public void InitPopup(int[] charaSkinIds)
		{
		}

		private void GoSummonScene()
		{
		}

		private void ShowReleaseCharaSkinPopup(int charaSkinId)
		{
		}

		private void ShowSkinReleaseResultPopup(int charaSkinId)
		{
		}
	}
}

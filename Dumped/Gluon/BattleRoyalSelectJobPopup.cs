using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class BattleRoyalSelectJobPopup : PopupBase
	{
		public enum Mode
		{
			SelectJob,
			SelectSkin
		}

		[SerializeField]
		[Header("Content")]
		public RectTransform layoutParent;

		public BattleRoyalJobCell templateCell;

		public GameObject[] selectJobGOs;

		public GameObject[] selectSkinGOs;

		private Mode mode;

		private Dictionary<WeaponType, BattleRoyalJobCell> cellList;

		public static BattleRoyalSelectJobPopup Create(Mode mode)
		{
			return null;
		}

		private void Setup(Mode mode)
		{
		}

		private void UpdateSelectedSkin(WeaponType wt)
		{
		}

		private void OnDecided(WeaponType wt, bool isValid)
		{
		}
	}
}

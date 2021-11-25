using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BattleRoyalFinalConfirmPopup : PopupBase
	{
		public enum Mode
		{
			SelectJob,
			GoShop
		}

		[SerializeField]
		[Header("Content")]
		public Graphic icon;

		public Graphic jobIcon;

		public Text jobTitle;

		public Text jobDescription;

		public GameObject[] selectJobGOs;

		public GameObject[] goShopGOs;

		private Mode mode;

		private WeaponType selectedWeaponType;

		private Action<bool> onDone;

		private AnimationUICanvas.AnimationPattern exitPattern;

		public static BattleRoyalFinalConfirmPopup Create(Mode mode, WeaponType selectedWeaponType, Action<bool> onDone, AnimationUICanvas.AnimationPattern nowPageExitPattern = AnimationUICanvas.AnimationPattern.Pattern_1)
		{
			return null;
		}

		private void Setup(Mode mode, WeaponType selectedWeaponType, Action<bool> onDone, AnimationUICanvas.AnimationPattern exitPattern)
		{
		}

		public void OnDecided()
		{
		}

		public void OnCancel()
		{
		}
	}
}

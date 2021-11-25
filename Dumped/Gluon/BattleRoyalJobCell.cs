using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BattleRoyalJobCell : MonoBehaviour
	{
		[SerializeField]
		[Header("Content")]
		public GameObject invalidMask;

		public RawImage weaponIcon;

		public Text weaponText;

		public Graphic icon;

		public GameObject randomGO;

		private WeaponType weaponType;

		private int charaId;

		private bool isValid;

		private BattleRoyalSelectJobPopup.Mode mode;

		private Action<WeaponType, bool> onDecided;

		public void Setup(BattleRoyalSelectJobPopup.Mode mode, bool isValid, WeaponType weaponType, int charaId, bool isRandom, Action<WeaponType, bool> onDecided)
		{
		}

		public void OnPressed()
		{
		}
	}
}

using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyEquipTalisman : MonoBehaviour
	{
		public Image talismanIcon;

		public Text abilityText;

		public Text abilityText2;

		public GameObject emptyObject;

		public GameObject talismanInfoObject;

		private ulong talismanId;

		private Action onChangedCallback;

		private bool isSupportFriend;

		public void Setup(ulong talismanId, Action onChangedCallback, bool isSupportFriend = false)
		{
		}

		private void SetAbility2NameText(string abilityName)
		{
		}

		public void OnChangeButtonPressed()
		{
		}

		public void OpenDetailScene()
		{
		}

		public void SetupTalismanSetCell(ulong talismanKeyId)
		{
		}
	}
}

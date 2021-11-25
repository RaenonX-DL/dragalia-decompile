using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttCharacterInitializeData
	{
		public enum PrefabType
		{
			Character,
			Dragon,
			Enemy,
			Boss,
			OneImage,
			Raid,
			UI,
			Flash,
			HighBoss
		}

		public enum PartyCharacterType
		{
			None,
			Party1,
			Party2,
			Party3,
			Party4
		}

		public static readonly string[] prefabFolder;

		[SerializeField]
		public PrefabType prefabType;

		[SerializeField]
		public string characterPrefabName;

		[SerializeField]
		public string animationControllerName;

		[SerializeField]
		public bool ignoreOverrideAnimationController;

		[SerializeField]
		public string weaponPrefabName;

		[SerializeField]
		public CuttLayer.Type layerType;

		[SerializeField]
		public PartyCharacterType partyCharacterType;

		[SerializeField]
		public bool removePartyCharacterWeapon;

		[SerializeField]
		public List<string> gameObjectNameList;
	}
}

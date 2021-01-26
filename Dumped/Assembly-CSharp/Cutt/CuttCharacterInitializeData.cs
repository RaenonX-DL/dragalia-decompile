/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttCharacterInitializeData
	{
		// Fields
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
	
		// Nested types
		public enum PrefabType
		{
			Character = 0,
			Dragon = 1,
			Enemy = 2,
			Boss = 3,
			OneImage = 4,
			Raid = 5,
			UI = 6,
			Flash = 7,
			HighBoss = 8
		}
	
		public enum PartyCharacterType
		{
			None = 0,
			Party1 = 1,
			Party2 = 2,
			Party3 = 3,
			Party4 = 4
		}
	
		// Constructors
		public CuttCharacterInitializeData();
		static CuttCharacterInitializeData();
	}
}

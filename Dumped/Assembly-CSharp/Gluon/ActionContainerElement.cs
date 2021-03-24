/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionContainerElement
	{
		// Fields
		private int _actionId;
		private string _name;
		public ActionParts[] array_parts;
	
		// Properties
		public int actionId { get; }
		public string name { get; }
	
		// Constructors
		public ActionContainerElement();
	
		// Methods
		public void Load(GameObject resource, CharacterBase owner, bool isOtherPlayer);
		public static void ConfirmLoadResources(ActionParts element, CharacterBase owner, bool isOtherPlayer, ActionContainerElement container = null);
		private static void SetEffectGroupList(ActionContainerElement container, string name, bool isOtherPlayer, CharacterBase owner);
		private static void SetSeGroupList(ActionContainerElement container, string name);
		private static void SetEffectGroupListForCharacterElement(CharacterBase owner, ActionContainerElement container, string[] elementEffectNames, bool isOtherPlayer, bool isAddPool = false);
		private static bool SetEffectGroupListForShareCharacterElement(CharacterBase owner, ActionContainerElement container, int skillIndex, string[] elementEffectNames, bool isOtherPlayer, bool isAddPool);
		private static bool SetEffectGroupListForCharacterElement(CharacterBase owner, ActionContainerElement container, ElementalType elementalType, string[] elementEffectNames, bool isOtherPlayer, bool isAddPool);
		private static bool SetSeGroupListForShareCharacterElement(CharacterBase owner, ActionContainerElement container, int skillIndex, string[] elementSeNames);
		private static ElementalType GetShareCharacterElement(CharacterBase owner, int skillIndex);
	}
}

using System.Runtime.InteropServices;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionContainerElement
	{
		private int _actionId;

		private string _name;

		public Gluon.ActionData.ActionParts[] array_parts;

		public int actionId => default(int);

		public string name => null;

		public void Load(GameObject resource, CharacterBase owner, bool isOtherPlayer)
		{
		}

		public static void ConfirmLoadResources(Gluon.ActionData.ActionParts element, CharacterBase owner, bool isOtherPlayer, [Optional] ActionContainerElement container)
		{
		}

		private static void SetEffectGroupList(ActionContainerElement container, string name, bool isOtherPlayer, CharacterBase owner, bool isSeparatelyLoadEffect)
		{
		}

		private static void SetSeGroupList(ActionContainerElement container, string name)
		{
		}

		private static void LoadAnimatableObject(Gluon.ActionData.ActionParts element)
		{
		}

		private static void SetEffectGroupListForCharacterElement(CharacterBase owner, ActionContainerElement container, string[] elementEffectNames, bool isOtherPlayer, bool isAddPool = false)
		{
		}

		private static bool SetEffectGroupListForShareCharacterElement(CharacterBase owner, ActionContainerElement container, int skillIndex, string[] elementEffectNames, bool isOtherPlayer, bool isAddPool)
		{
			return default(bool);
		}

		private static bool SetEffectGroupListForCharacterElement(CharacterBase owner, ActionContainerElement container, ElementalType elementalType, string[] elementEffectNames, bool isOtherPlayer, bool isAddPool)
		{
			return default(bool);
		}

		private static bool SetSeGroupListForShareCharacterElement(CharacterBase owner, ActionContainerElement container, int skillIndex, string[] elementSeNames)
		{
			return default(bool);
		}

		private static ElementalType GetShareCharacterElement(CharacterBase owner, int skillIndex)
		{
			return default(ElementalType);
		}
	}
}

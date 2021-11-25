using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon
{
	[DisallowMultipleComponent]
	public class DungeonEffectModifier : MonoBehaviour
	{
		[SerializeField]
		private List<DungeonEffectPlayParameter> _modifierList;

		public DungeonEffectPlayParameter GetPlayParameter(string effectName)
		{
			return null;
		}
	}
}

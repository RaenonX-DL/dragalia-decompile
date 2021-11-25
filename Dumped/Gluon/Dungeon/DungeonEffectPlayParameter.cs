using System;
using UnityEngine;

namespace Gluon.Dungeon
{
	[Serializable]
	public class DungeonEffectPlayParameter
	{
		[Tooltip("ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088å\u0090\u008d")]
		public string effectName;

		[Tooltip("å\u0086\u008dç\u0094\u009fé\u0080\u009fåº¦")]
		public float effectSpeed;

		[Tooltip("ä¹\u0097ç®\u0097ã\u0082«ã\u0083©ã\u0083¼")]
		public Color effectColor;

		[Tooltip("ä\u00b8\u008dé\u0080\u008fæ\u0098\u008eåº¦")]
		public float effectOpacity;
	}
}

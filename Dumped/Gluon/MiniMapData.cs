using System;
using Cute.UI;
using UnityEngine;

namespace Gluon
{
	public class MiniMapData : MonoBehaviour
	{
		[Serializable]
		public struct MapChipSprite
		{
			[Tooltip("å\u0086\u008dè\u00a8­å®\u009aã\u0081®ã\u0082¹ã\u0083\u0097ã\u0083©ã\u0082¤ã\u0083\u0088å\u0090\u008d")]
			public string spriteName;

			[Tooltip("å\u0086\u008dè\u00a8­å®\u009aå\u00af¾è±¡ã\u0081®ã\u0082¹ã\u0083\u0097ã\u0083©ã\u0082¤ã\u0083\u0088ã\u0083¬ã\u0083³ã\u0083\u0080ã\u0083©ã\u0083¼")]
			public SpriteRenderer spriteRenderer;
		}

		[SerializeField]
		[ReadOnly]
		[Tooltip("ã\u0083\u009eã\u0083\u0083ã\u0083\u0097ã\u0083\u0081ã\u0083\u0083ã\u0083\u0097ç\u0094\u00a8ã\u0081®ã\u0082¹ã\u0083\u0097ã\u0083©ã\u0082¤ã\u0083\u0088æ\u0083\u0085å\u00a0±")]
		private MapChipSprite[] _mapChipSprites;

		[SerializeField]
		[ReadOnly]
		[Tooltip("å\u0086\u008dè\u00a8­å®\u009aç\u0094\u00a8ã\u0081®ã\u0082¢ã\u0083\u0088ã\u0083©ã\u0082¹æ\u0083\u0085å\u00a0±")]
		private AtlasReference[] _atlasReferences;

		private Sprite GetSprite(AtlasReference atlasReference, string name)
		{
			return null;
		}

		private void Awake()
		{
		}
	}
}

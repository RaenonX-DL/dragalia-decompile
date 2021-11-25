using System;
using UnityEngine;

namespace Gluon
{
	[CreateAssetMenu]
	public class BackgroundImageLayerObject : ScriptableObject
	{
		[Serializable]
		public class BackgroundImageLayer
		{
			public Material material;

			public Vector2 scrollSpeed;

			public float trancateTop;

			public float trancateBottom;

			public Vector2 offsetUV;
		}

		public BackgroundImageLayer[] layerData;
	}
}

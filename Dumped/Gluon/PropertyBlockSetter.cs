using System;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class PropertyBlockSetter : FastUpdateMonoBehaviour
	{
		[Serializable]
		public class PropertyNameAndTexturePair
		{
			public string propertyName;

			public Texture2D texture;
		}

		[SerializeField]
		private PropertyNameAndTexturePair[] settings;

		private MaterialPropertyBlock materialPropertyBlock;

		private void Start()
		{
		}
	}
}

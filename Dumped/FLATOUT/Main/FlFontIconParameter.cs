using System;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlFontIconParameter
	{
		[SerializeField]
		private Texture _colorTexture;

		[SerializeField]
		private Texture _alphaTexture;

		public Texture ColorTexture => null;

		public Texture AlphaTexture => null;
	}
}

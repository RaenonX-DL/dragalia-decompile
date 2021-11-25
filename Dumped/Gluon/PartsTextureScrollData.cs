using System;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	internal class PartsTextureScrollData : TextureScrollData
	{
		[SerializeField]
		[Tooltip("å\u00af¾è±¡ã\u0081®ã\u0083\u0091ã\u0083¼ã\u0083\u0084å\u0090\u008d")]
		public string partsName;

		[HideInInspector]
		public MaterialPropertyData materialPropertyData;
	}
}

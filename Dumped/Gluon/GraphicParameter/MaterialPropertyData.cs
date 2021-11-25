using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon.GraphicParameter
{
	[Serializable]
	public class MaterialPropertyData
	{
		public bool isEnable => default(bool);

		public MaterialPropertyBlock materialPropertyBlock
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MaterialPropertyData(string name)
		{
		}

		public void SetPropertyBlock(Renderer renderer, int materialIndex = -1)
		{
		}
	}
}

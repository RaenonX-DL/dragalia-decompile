using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon.GraphicParameter
{
	[Serializable]
	public class MaterialPropertyRenderer : MaterialPropertyData
	{
		[Serializable]
		public class RendererData
		{
			public Renderer renderer;

			public int materialIndex;

			public RendererData([Optional] Renderer r, int index = -1)
			{
			}
		}

		public List<RendererData> rendererDataList;

		public MaterialPropertyRenderer(string name)
		{
		}

		public void AddRenderer(Renderer[] renderers, int index = -1)
		{
		}

		public void AddRenderer(List<Renderer> renderers, int index = -1)
		{
		}

		public void AddRenderer(Renderer renderer, int index = -1)
		{
		}

		public void SetPropertyBlockAll()
		{
		}
	}
}

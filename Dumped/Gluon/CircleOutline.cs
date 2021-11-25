using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	[AddComponentMenu("UI/Effects/CircleOutline")]
	public class CircleOutline : Outline
	{
		[SerializeField]
		private bool useGraphicRedAsAlpha;

		private const int quality = 8;

		private List<UIVertex> list;

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		protected void ModifyVertices()
		{
		}

		protected void ApplyShadow(int start, int end, float x, float y)
		{
		}
	}
}

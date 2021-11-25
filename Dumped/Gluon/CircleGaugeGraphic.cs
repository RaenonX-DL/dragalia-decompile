using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CircleGaugeGraphic : Graphic
	{
		public int numOfTriangle;

		public int radius;

		public float gaugeValue;

		public string materialPath;

		private Texture texture;

		private List<UIVertex> verts;

		private List<int> indicies;

		private Material gaugeMaterial;

		private Texture gaugeTexture;

		public override Texture mainTexture => null;

		protected override void Awake()
		{
		}

		public void SetGaugeRange(float range)
		{
		}

		public void ResetVerts()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}
	}
}

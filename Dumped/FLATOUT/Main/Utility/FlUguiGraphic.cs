using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FLATOUT.Main.Utility
{
	public class FlUguiGraphic : MaskableGraphic
	{
		public UIVertex[] vertices;

		private List<UIVertex> verts;

		private List<int> indicies;

		private Vector2 position;

		private Texture texture;

		public override Texture mainTexture => null;

		protected override void Awake()
		{
		}

		public void Initialize()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		public void SetVertexPosition(Vector3[] posVec)
		{
		}

		public void SetUV(float u, float v, float w, float h, bool rotated)
		{
		}

		public void SetColorOffset(Vector2[] colorOffsetList0, Vector2[] colorOffsetList1)
		{
		}

		public void SetColor(Color[] color)
		{
		}

		public void SetMaterial(Material mat, Texture mainTex, Texture alphaTex)
		{
		}

		public void Refresh()
		{
		}
	}
}

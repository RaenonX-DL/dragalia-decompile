using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ClockWorkEffect : BaseMeshEffect
	{
		private Color32 effectColor;

		private float effectValue;

		private static Vector2[] initVertex;

		private bool init;

		private bool updateColor;

		private bool failure;

		private List<UIVertex> vList;

		private List<UIVertex> setList;

		private UIVertex verts;

		private UIVertex vertexZero;

		private const int numTriangle = 8;

		private const int numVertex = 3;

		private float minX;

		private float minY;

		private float minU;

		private float minV;

		private float width;

		private float height;

		private float widthU;

		private float heightV;

		public Color32 EffectColor
		{
			get
			{
				return default(Color32);
			}
			set
			{
			}
		}

		public float EffectValue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		private void Refresh()
		{
		}

		private void SetEffectColor(Color32 col)
		{
		}

		private void SetEffectValue(float v)
		{
		}
	}
}

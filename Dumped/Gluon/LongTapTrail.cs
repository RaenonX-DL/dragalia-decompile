using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class LongTapTrail : Graphic
	{
		public class MeshRect
		{
			public float x;

			public float y;

			public UIVertex[] vertices;

			public void SetPosition(float x, float y, float angle, int index)
			{
			}

			public void SetUV(int index)
			{
			}

			public void Reset()
			{
			}
		}

		public static float widthHalf;

		public static float heightHalf;

		public static int rectNum;

		public static int divideNum;

		public static float adjustRate;

		private bool isShown;

		private int count;

		private float angle;

		private Texture texture;

		public MeshRect[] meshRects;

		private List<UIVertex> verts;

		private List<int> indicies;

		public override Texture mainTexture => null;

		protected override void Awake()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		public void Show(float x, float y)
		{
		}

		public void Hide()
		{
		}
	}
}

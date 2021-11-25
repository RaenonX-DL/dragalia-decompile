using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class LongTapParticle : Graphic
	{
		private class MeshRect
		{
			public float x;

			public float y;

			public float alpha;

			public float scale;

			public float scale1Time;

			private float sizeHalf;

			public UIVertex[] vertices;

			public void SetPosition(float x, float y, float size)
			{
			}

			public void DecrementAlpha(float delta)
			{
			}

			public void DoScaleAnimation(float timeDec1, float delta1, float delta2)
			{
			}

			private void SetColor(float alpha)
			{
			}
		}

		public float particleScaleDelta1;

		public float particleScaleDelta2;

		private int particleNum;

		private int particleIndex;

		private float particleAlphaDec;

		private float particleScaleDec;

		private static Vector3 initialPosition;

		private Texture texture;

		private List<UIVertex> verts;

		private List<int> indicies;

		private MeshRect[] meshRects;

		public override Texture mainTexture => null;

		protected override void Awake()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		public void AddParticle(float x, float y, float size)
		{
		}

		public void Update()
		{
		}
	}
}

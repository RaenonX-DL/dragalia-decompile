using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gluon
{
	public class TextEffect : UIBehaviour, IMeshModifier
	{
		public enum EffectType
		{
			CurveArrange,
			Rotate
		}

		[SerializeField]
		private EffectType type;

		[SerializeField]
		private float unitLiftY;

		[SerializeField]
		private float rotateAngle;

		private const int vertexNumPerCharacter = 6;

		private List<UIVertex> vertexStream;

		public void ModifyMesh(Mesh mesh)
		{
		}

		public void ModifyMesh(VertexHelper verts)
		{
		}

		private void ModifyBytype(ref List<UIVertex> stream)
		{
		}

		private void CurveArrange(ref List<UIVertex> stream)
		{
		}

		private void Rotate(ref List<UIVertex> stream)
		{
		}
	}
}

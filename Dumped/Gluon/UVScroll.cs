using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class UVScroll : FastUpdateMonoBehaviour
	{
		public bool enableDirectionVertical;

		public bool enableDirectionHorizontal;

		public float scrollSpeed;

		private Renderer rend;

		[SerializeField]
		private bool isMaterialShared;

		[SerializeField]
		private bool isCreateAddtionalMeshForUV;

		private MeshRenderer orgMeshRenderer;

		private MeshFilter orgMeshFilter;

		private Mesh orgMesh;

		private Vector2[] addtionalUVs;

		private Mesh addtionalUvStream;

		private Vector2 tempVector2;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}

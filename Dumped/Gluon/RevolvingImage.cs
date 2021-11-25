using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RevolvingImage : BaseMeshEffect
	{
		[SerializeField]
		[Header("parameter")]
		private float perspective;

		private UIVertex v;

		private float revolve;

		private Material backMaterial;

		private Sprite backSprite;

		private float duration;

		private float lapse;

		private bool doing;

		private bool done;

		private Image image;

		public void Initialize()
		{
		}

		private void Update()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		private void Refresh()
		{
		}

		public void StartRevolve(Material material, float time)
		{
		}

		public void StartRevolve(Sprite sprite, float time)
		{
		}
	}
}

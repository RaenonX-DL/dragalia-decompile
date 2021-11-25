using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GradientColor : BaseMeshEffect
	{
		private UIVertex v;

		private Color32 topColor;

		private Color32 bottomColor;

		public Color32 TopColor
		{
			get
			{
				return default(Color32);
			}
			set
			{
			}
		}

		public Color32 BottomColor
		{
			get
			{
				return default(Color32);
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

		private void SetTopColor(Color32 col)
		{
		}

		private void SetBottomColor(Color32 col)
		{
		}
	}
}

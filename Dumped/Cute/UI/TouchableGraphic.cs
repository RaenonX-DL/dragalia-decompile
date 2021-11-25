using UnityEngine;
using UnityEngine.UI;

namespace Cute.UI
{
	public class TouchableGraphic : Graphic
	{
		public override bool Raycast(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}
	}
}

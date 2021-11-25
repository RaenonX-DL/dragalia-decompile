using UnityEngine;

namespace Gluon
{
	public class CameraGroupCronos : CameraGroupCtrl
	{
		[SerializeField]
		[Tooltip("è\u0083\u008cæ\u0099\u00afæ\u008f\u008fç\u0094»ç\u0094\u00a8ã\u0081®ã\u0082«ã\u0083¡ã\u0083©")]
		private Camera backgroundCamera;

		public override int GetRenderLayer(Material material)
		{
			return default(int);
		}

		private void LateUpdate()
		{
		}
	}
}

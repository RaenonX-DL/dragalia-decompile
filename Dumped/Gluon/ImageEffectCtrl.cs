using UnityEngine;

namespace Gluon
{
	public abstract class ImageEffectCtrl : MonoBehaviour
	{
		protected CameraData mainCameraData;

		public virtual void Initialize(CameraGroupCtrl cameraGroupCtrl)
		{
		}
	}
}

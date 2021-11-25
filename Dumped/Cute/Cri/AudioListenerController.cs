using UnityEngine;

namespace Cute.Cri
{
	public class AudioListenerController : MonoBehaviour
	{
		[SerializeField]
		private CriAtomListener listener;

		private float listenerLerpValue;

		public void Enable3dListener(bool isEnable)
		{
		}

		public void SetListenerLerpValue(float listenerLerpValue)
		{
		}

		public void Update3dListenerPos(Transform cameraTrans, Transform playerTrans)
		{
		}

		public Vector3 Get3dListenerPos()
		{
			return default(Vector3);
		}

		public void Set3dListenerPos(Vector3 listenerPos)
		{
		}

		public Quaternion Get3dListenerRot()
		{
			return default(Quaternion);
		}

		public void Set3dListenerRot(Quaternion listenerRot)
		{
		}

		public void OnDrawGizmos()
		{
		}
	}
}

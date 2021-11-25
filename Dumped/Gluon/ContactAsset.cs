using UnityEngine;

namespace Gluon
{
	public class ContactAsset : ScriptableObject
	{
		[SerializeField]
		public int dragonBaseID;

		[SerializeField]
		[Header("Camera")]
		public Vector3 baseViewCam;

		public Vector3 baseRotCam;

		public Vector3 actionViewCam;

		public Vector3 actionRotCam;

		public void CopyFrom(ContactAsset sampleAsset)
		{
		}
	}
}

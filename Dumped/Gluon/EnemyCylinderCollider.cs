using Cute.Core;
using UnityEngine;

namespace Gluon
{
	[AddComponentMenu("_Gluon/Scripts/InGame/Common/CylinderCollider")]
	public class EnemyCylinderCollider : FastUpdateMonoBehaviour
	{
		private MeshCollider _meshCollider;

		private const int CYLINDER_ANGLE = 360;

		private const int VERTICES_NUM = 12;

		[SerializeField]
		private float _radius;

		[SerializeField]
		private float _height;

		[SerializeField]
		private Vector3 _offset;

		[SerializeField]
		private float _pushPowerRate;

		[SerializeField]
		[Header("é«\u0098ã\u0081\u0095ã\u0081\u008bã\u0082\u0089é\u0080\u0086ç®\u0097ã\u0081\u0097ã\u0081¦ã\u0082³ã\u0083©ã\u0082¤ã\u0083\u0080ã\u0083¼ã\u0081®ä½\u008dç½®ã\u0082\u0092å\u009c°é\u009d¢ï¼\u0088y=0ï¼\u0089ã\u0081\u00a8å\u0090\u0088ã\u0082\u008fã\u0081\u009bã\u0082\u008bã\u0081\u008b")]
		private bool _floorAlignment;

		[SerializeField]
		[Header("ã\u0082·ã\u0083ªã\u0083³ã\u0083\u0080ã\u0083¼ã\u0082\u0092æ\u00a8ªã\u0081«å\u0080\u0092ã\u0081\u0099ã\u0081\u008b")]
		private bool _lieDown;

		private float _oldRadius;

		private float _oldHeight;

		private Vector3 _oldOffset;

		private Vector2 meshColliderCenterPositionXZ;

		private Vector2 charaColliderCenterPositionXZ;

		public float radius => default(float);

		public float height => default(float);

		protected MeshCollider meshCollider => null;

		private void Awake()
		{
		}

		public void CreateCylinderCollider(float radius, float height, int fanAngle, Vector3 offset, int numVertices = 32)
		{
		}

		private Mesh CreateMesh(float radius, float height, Vector3 offSet, int angle, int numVertices)
		{
			return null;
		}

		private void LateUpdate()
		{
		}
	}
}

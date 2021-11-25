using UnityEngine;

namespace Gluon
{
	public class PlayerFootMark : MonoBehaviour
	{
		public enum Type
		{
			None,
			Move,
			Attack,
			Raid
		}

		[SerializeField]
		[Header("component")]
		private MeshRenderer circleMeshRenderer;

		[SerializeField]
		private MeshRenderer arrowMeshRenderer;

		[SerializeField]
		private Transform circleRootTrs;

		[SerializeField]
		private Transform arrowRootTrs;

		[SerializeField]
		[Header("resource")]
		private Texture2D move;

		[SerializeField]
		private Texture2D attack;

		[SerializeField]
		private Texture2D raid;

		[SerializeField]
		private Texture2D arrow;

		[SerializeField]
		[Header("parameter")]
		private float rotSpeed;

		private Transform circleTrs;

		private Transform arrowTrs;

		private Material circleMaterial;

		private CharacterBase chara;

		private Type currentType;

		private float lastRotY;

		private float scaleArrow;

		private CameraController cameraCtrl;

		private bool isActiveCircle;

		private bool isActiveArrow;

		private void VisibleCircle(bool b, bool force = false)
		{
		}

		private void VisibleArrow(bool b, bool force = false)
		{
		}

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void ChangeMark(Type type)
		{
		}

		public void AttachMark(CharacterBase chara, Type type)
		{
		}

		public void DetachMark(CharacterBase chara)
		{
		}

		public void DetachMark()
		{
		}

		private bool IsInputMove(out Vector3 inputDir)
		{
			return default(bool);
		}
	}
}

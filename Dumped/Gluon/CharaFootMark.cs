using DG.Tweening;
using Gluon.Dungeon;
using UnityEngine;

namespace Gluon
{
	public class CharaFootMark : MonoBehaviour
	{
		public enum Type
		{
			None,
			Target
		}

		[SerializeField]
		[Header("component")]
		private MeshFilter[] circleMeshFilter;

		[SerializeField]
		private MeshFilter[] arrowMeshFilter;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("(s)")]
		private float animTime;

		[SerializeField]
		[Tooltip("x -> y")]
		private Vector2 animScale;

		[SerializeField]
		[Tooltip("(x, z)")]
		private Vector2[] animVec;

		[SerializeField]
		[Tooltip("x -> y")]
		private Vector2 animMove;

		[SerializeField]
		[Tooltip("(rate)")]
		private float startArrow;

		[SerializeField]
		private Vector3 rotY;

		private const int numCirclePart = 4;

		private const int numArrow = 4;

		private Color32 white32;

		private GameObject[] circleGo;

		private GameObject[] arrowGo;

		private Transform[] circleT;

		private Transform[] arrowT;

		private Mesh[] circleMesh;

		private Mesh[] arrowMesh;

		private CharacterBase chara;

		private DungeonObjectBase obj;

		private Type currentType;

		private CharacterBase reserveChara;

		private DungeonObjectBase reserveObj;

		private Type reserveType;

		private bool dirty;

		private Tweener tweenerScale;

		private Tweener tweenerMove;

		private Tweener tweenerCircleAlpha;

		private Tweener tweenerArrowAlpha;

		private Color32[] circleColors;

		private Color32[] arrowColors;

		private const float tweenerMoveEndValue = 1f;

		private const float tweenerArrowAlphaEndValue = 1f;

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		private void Active(bool b)
		{
		}

		private void StopTweener()
		{
		}

		private void ChangeMark(Type type)
		{
		}

		public void AttachMark(CharacterBase chara, Type type)
		{
		}

		private void AttachMarkFunc(CharacterBase chara, Type type)
		{
		}

		public void AttachMark(DungeonObjectBase obj, Type type)
		{
		}

		private void AttachMarkFunc(DungeonObjectBase obj, Type type)
		{
		}

		public void DetachMark(CharacterBase chara)
		{
		}

		public void DetachMark(DungeonObjectBase obj)
		{
		}

		public void DetachMark()
		{
		}

		private bool IsTargetOwn(CharacterBase chara)
		{
			return default(bool);
		}

		private bool IsTargetOwn(DungeonObjectBase obj)
		{
			return default(bool);
		}

		private void OnUpdateScale(float value)
		{
		}

		private void OnUpdateCircleAlpha(float value)
		{
		}

		private void OnUpdateMove(float value)
		{
		}

		private void OnUpdateArrowAlpha(float value)
		{
		}

		public void SetScale(CharacterBase target, float scale)
		{
		}
	}
}

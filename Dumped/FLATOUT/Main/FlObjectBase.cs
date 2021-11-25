using UnityEngine;

namespace FLATOUT.Main
{
	public class FlObjectBase : FlBase
	{
		protected FlMotion _parentMotion;

		protected FlObjectParameterBase _parameter;

		protected int _objectIndex;

		protected GameObject _offsetObject;

		protected Transform _offsetTransform;

		protected bool _existOffsetObject;

		protected FlBlendModeTypes _blendModeType;

		protected int _existCollider;

		protected Collider _collider;

		protected Collider2D _collider2D;

		protected int _existSubCollider;

		protected Collider _subCollider;

		protected Vector3 _placeOffset;

		protected float _placeScale;

		protected Vector3 _currentPosition;

		protected Vector3 _currentPositionOffset;

		protected Vector3 _currentRotate;

		protected Vector3 _currentScale;

		protected Vector2 _currentShear;

		protected Vector3 _prevPosition;

		protected Vector3 _prevPositionOffset;

		protected Vector3 _prevRotate;

		protected Vector3 _prevScale;

		protected Vector2 _prevShear;

		protected Vector4 _currentShearCosSin;

		protected bool _positionChanged;

		protected bool _positionOffsetChanged;

		protected bool _rotateChanged;

		protected bool _scaleChanged;

		protected bool _shearChanged;

		protected int[] _positionKeyIndex;

		protected int[] _positionOffsetKeyIndex;

		protected int[] _rotateKeyIndex;

		protected int[] _scaleKeyIndex;

		protected int[] _shearKeyIndex;

		protected float _localDepthOffset;

		protected float _fixLocalDepthOffset;

		protected Color _baseColor;

		protected Color _baseColorOffset;

		protected bool _colorChanged;

		protected bool _colorOffsetChanged;

		protected int[] _colorKeyIndex;

		protected int[] _colorOffsetKeyIndex;

		protected bool _blurChanged;

		protected int[] _blurValueKeyIndex;

		public FlObjectParameterBase Parameter => null;

		public FlMotion ParentMotion => null;

		public GameObject OffsetObject => null;

		public bool ExistOffsetObject => default(bool);

		public FlBlendModeTypes BlendModeType => default(FlBlendModeTypes);

		public int ObjectIndex => default(int);

		public Vector3 CurrentPosition => default(Vector3);

		public Vector3 CurrentPositionOffset => default(Vector3);

		public Vector3 CurrentRotate => default(Vector3);

		public Vector3 CurrentScale => default(Vector3);

		public Vector2 CurrentShear => default(Vector2);

		public Color BaseColor => default(Color);

		public float BaseAlpha => default(float);

		public Color BaseColorOffset => default(Color);

		public float BaseAlphaOffset => default(float);

		public Collider Collider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Collider2D Collider2D => null;

		public Collider SubCollider => null;

		public int ExistSubCollider => default(int);

		public FlObjectBase(GameObject gameObject)
		{
		}

		public virtual void _CreateEditorData(FlObjectParameterBase parameter, FlMotion parentMotion)
		{
		}

		public virtual void _ApplyData(FlObjectParameterBase parameter, FlMotion parentMotion)
		{
		}

		public override void _CreateData()
		{
		}

		private void _CheckCollision()
		{
		}

		private void _CheckParentMotion()
		{
		}

		protected override void _ResetPrevValue()
		{
		}

		public override void _ResetTime()
		{
		}

		public override void _FixData()
		{
		}

		public override void _FinalizeData()
		{
		}

		private void _CalculatePlaceOffset()
		{
		}

		private void _SetDepth()
		{
		}

		private void _CheckUI()
		{
		}

		private void _CreateUI()
		{
		}

		public override void _UpdateFirst()
		{
		}

		public override void _UpdateSecond()
		{
		}

		protected virtual void _UpdateVisible()
		{
		}

		protected virtual void _UpdateColor()
		{
		}

		protected virtual void _UpdateTransform()
		{
		}

		protected void _UpdateShear()
		{
		}

		protected virtual void _UpdateBlurValue()
		{
		}

		protected virtual void _UpdateEnableCollision(bool enable)
		{
		}

		protected override void _UpdateSortOrder()
		{
		}

		protected override void _UpdateSortLayer()
		{
		}

		public override void SetSortOffset(int sortOffset)
		{
		}

		public override void SetSortLayer(string sortLayerName)
		{
		}

		public override void SetColliderThrough(bool through, bool affectChildren)
		{
		}

		public override void SetColliderThicknessOffset(float thicknessOffset, bool affectChildren)
		{
		}

		public override void _UpdateColliderThickness(bool affectChildren)
		{
		}

		public override void SetEnableCollider(bool enable, bool affectChildren)
		{
		}

		public override void SetSubCollider(Collider subCollider, bool affectChildren)
		{
		}

		public string GetFlagValue(int flagNo)
		{
			return null;
		}

		public virtual void SetBaseColor(Color value)
		{
		}

		public virtual void SetBaseAlpha(float alpha)
		{
		}

		public virtual void SetBaseColorOffset(Color value)
		{
		}

		public virtual void SetBaseAlphaOffset(float value)
		{
		}

		public override void SetBlurQuality(int blurQuality, int blurPrecision, bool affectChildren)
		{
		}

		public override void SetBlurValue(Vector2 blurValue, bool affectChildren)
		{
		}

		public override void UpdateTransformVariables()
		{
		}
	}
}

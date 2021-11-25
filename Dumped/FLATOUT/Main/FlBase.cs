using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlBase
	{
		public FlRoot _root;

		protected string _id;

		protected GameObject _gameObject;

		protected Transform _transform;

		protected bool _visible;

		public bool _visibleInHierarchy;

		protected bool _isInTimeRange;

		protected FlObjectTypes _objectType;

		protected bool _updateFlag;

		protected Color _multiplyColor;

		protected Color _colorOffset;

		public Color _currentColor;

		public Color _currentColorOffset;

		protected Color _prevColor;

		protected Color _prevColorOffset;

		protected Vector2 _blurValue;

		protected Vector2 _currentBlurValue;

		protected Vector2 _prevBlurValue;

		protected int _blurPrecision;

		protected int _currentBlurPrecision;

		protected int _prevBlurPrecision;

		protected int _blurQuality;

		protected int _currentBlurQuality;

		protected int _prevBlurQuality;

		protected bool _isGrayscale;

		protected bool _prevIsGrayscale;

		protected string _layerName;

		protected int _layerIndex;

		public int _sortOffset;

		public int _localSortOffset;

		public string _sortLayerName;

		protected int _sortOrderIndex;

		protected int _sortOrder;

		protected int _sortOrderIndexForDrawTextLater;

		public float _motionSpeed;

		protected bool _enableCollider;

		protected bool _colliderThrough;

		protected float _colliderThicknessOffset;

		protected int _stencilRef;

		protected int _prevStencilRef;

		protected int _localStencilRefOffset;

		public FlTimeModeTypes _timeModeType;

		public FlRoot Root => null;

		public GameObject GameObject => null;

		public Transform Transform => null;

		public string ID => null;

		public bool Visible => default(bool);

		public bool VisibleInHierarchy => default(bool);

		public FlObjectTypes ObjectType => default(FlObjectTypes);

		public bool IsGrayscale => default(bool);

		public string LayerName => null;

		public int LayerIndex => default(int);

		public int SortOffset => default(int);

		public int LocalSortOffset => default(int);

		public string SortLayerName => null;

		public int SortOrderIndex => default(int);

		public int SortOrder => default(int);

		public int UGuiSortOrder
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int StencilRef => default(int);

		public int LocalStencilRefOffset => default(int);

		public FlTimeModeTypes TimeModeType => default(FlTimeModeTypes);

		public Color MultiplyColor => default(Color);

		public float MultiplyAlpha => default(float);

		public Color ColorOffset => default(Color);

		public float AlphaOffset => default(float);

		public Color CurrentColor => default(Color);

		public float CurrentAlpha => default(float);

		public Color CurrentColorOffset => default(Color);

		public float CurrentAlphaOffset => default(float);

		public bool EnableCollider => default(bool);

		public bool ColliderThrough => default(bool);

		public Vector2 CurrentBlurValue => default(Vector2);

		public int CurrentBlurQuality => default(int);

		public int CurrentBlurPrecision => default(int);

		public Vector2 BlurValue => default(Vector2);

		public int BlurQuality => default(int);

		public int BlurPrecision => default(int);

		public virtual void _CreateData()
		{
		}

		public virtual void _FixData()
		{
		}

		public virtual void _FinalizeData()
		{
		}

		protected virtual void _ResetPrevValue()
		{
		}

		public virtual void _Update()
		{
		}

		public virtual void _UpdateForce()
		{
		}

		public virtual void _UpdateFirst()
		{
		}

		public virtual void _UpdateSecond()
		{
		}

		public virtual void _ResetTime()
		{
		}

		public virtual void SetVisible(bool visible)
		{
		}

		public virtual void SetMultiplyColor(Color value)
		{
		}

		public virtual void SetMultiplyAlpha(float alpha)
		{
		}

		public virtual void SetColorOffset(Color value)
		{
		}

		public virtual void SetAlphaOffset(float value)
		{
		}

		public virtual void SetGrayscale(bool enable)
		{
		}

		protected virtual void _SetGrayscaleBase(bool enable)
		{
		}

		public virtual void SetLayer(string layerName)
		{
		}

		public virtual void SetLayer(int layerIndex)
		{
		}

		public virtual void SetSortOffset(int sortOffset)
		{
		}

		public virtual void SetSortLayer(string sortLayerName)
		{
		}

		public virtual void SetTimeModeType(FlTimeModeTypes timeModeType, bool affectChildren)
		{
		}

		public virtual void SetMotionSpeed(float speed, bool affectChildren)
		{
		}

		public virtual void SetColliderThrough(bool through, bool affectChildren)
		{
		}

		public virtual void SetColliderThicknessOffset(float thicknessOffset, bool affectChildren)
		{
		}

		public virtual void _UpdateColliderThickness(bool affectChildren)
		{
		}

		public virtual void SetEnableCollider(bool enable, bool affectChildren)
		{
		}

		public virtual void SetSubCollider(Collider subCollider, bool affectChildren)
		{
		}

		public virtual void SetBlurQuality(int blurQuality, int blurPrecision, bool affectChildren)
		{
		}

		public virtual void SetBlurValue(Vector2 blurValue, bool affectChildren)
		{
		}

		protected virtual void _UpdateSortOrder()
		{
		}

		protected virtual void _UpdateSortLayer()
		{
		}

		public virtual void _UpdateStencilRef(bool affectChildren)
		{
		}

		protected virtual void _UpdateStencilRefBase()
		{
		}

		public virtual void UpdateTransformVariables()
		{
		}
	}
}

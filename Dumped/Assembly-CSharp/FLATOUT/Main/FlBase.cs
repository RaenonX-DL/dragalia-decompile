/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlBase
	{
		// Fields
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
		[CompilerGenerated]
		private int _UGuiSortOrder_k__BackingField;
	
		// Properties
		public FlRoot Root { get; }
		public GameObject GameObject { get; }
		public Transform Transform { get; }
		public string ID { get; }
		public bool Visible { get; }
		public bool VisibleInHierarchy { get; }
		public FlObjectTypes ObjectType { get; }
		public bool IsGrayscale { get; }
		public string LayerName { get; }
		public int LayerIndex { get; }
		public int SortOffset { get; }
		public int LocalSortOffset { get; }
		public string SortLayerName { get; }
		public int SortOrderIndex { get; }
		public int SortOrder { get; }
		public int UGuiSortOrder { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int StencilRef { get; }
		public int LocalStencilRefOffset { get; }
		public FlTimeModeTypes TimeModeType { get; }
		public Color MultiplyColor { get; }
		public float MultiplyAlpha { get; }
		public Color ColorOffset { get; }
		public float AlphaOffset { get; }
		public Color CurrentColor { get; }
		public float CurrentAlpha { get; }
		public Color CurrentColorOffset { get; }
		public float CurrentAlphaOffset { get; }
		public bool EnableCollider { get; }
		public bool ColliderThrough { get; }
		public Vector2 CurrentBlurValue { get; }
		public int CurrentBlurQuality { get; }
		public int CurrentBlurPrecision { get; }
		public Vector2 BlurValue { get; }
		public int BlurQuality { get; }
		public int BlurPrecision { get; }
	
		// Constructors
		public FlBase();
	
		// Methods
		public virtual void _CreateData();
		public virtual void _FixData();
		public virtual void _FinalizeData();
		protected virtual void _ResetPrevValue();
		public virtual void _Update();
		public virtual void _UpdateForce();
		public virtual void _UpdateFirst();
		public virtual void _UpdateSecond();
		public virtual void _ResetTime();
		public virtual void SetVisible(bool visible);
		public virtual void SetMultiplyColor(Color value);
		public virtual void SetMultiplyAlpha(float alpha);
		public virtual void SetColorOffset(Color value);
		public virtual void SetAlphaOffset(float value);
		public virtual void SetGrayscale(bool enable);
		protected virtual void _SetGrayscaleBase(bool enable);
		public virtual void SetLayer(string layerName);
		public virtual void SetLayer(int layerIndex);
		public virtual void SetSortOffset(int sortOffset);
		public virtual void SetSortLayer(string sortLayerName);
		public virtual void SetTimeModeType(FlTimeModeTypes timeModeType, bool affectChildren);
		public virtual void SetMotionSpeed(float speed, bool affectChildren);
		public virtual void SetColliderThrough(bool through, bool affectChildren);
		public virtual void SetColliderThicknessOffset(float thicknessOffset, bool affectChildren);
		public virtual void _UpdateColliderThickness(bool affectChildren);
		public virtual void SetEnableCollider(bool enable, bool affectChildren);
		public virtual void SetSubCollider(Collider subCollider, bool affectChildren);
		public virtual void SetBlurQuality(int blurQuality, int blurPrecision, bool affectChildren);
		public virtual void SetBlurValue(Vector2 blurValue, bool affectChildren);
		protected virtual void _UpdateSortOrder();
		protected virtual void _UpdateSortLayer();
		public virtual void _UpdateStencilRef(bool affectChildren);
		protected virtual void _UpdateStencilRefBase();
		public virtual void UpdateTransformVariables();
	}
}

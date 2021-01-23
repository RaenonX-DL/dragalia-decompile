/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	public class FlObjectBase : FlBase
	{
		// Fields
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
	
		// Properties
		public FlObjectParameterBase Parameter { get; }
		public FlMotion ParentMotion { get; }
		public GameObject OffsetObject { get; }
		public bool ExistOffsetObject { get; }
		public FlBlendModeTypes BlendModeType { get; }
		public int ObjectIndex { get; }
		public Vector3 CurrentPosition { get; }
		public Vector3 CurrentPositionOffset { get; }
		public Vector3 CurrentRotate { get; }
		public Vector3 CurrentScale { get; }
		public Vector2 CurrentShear { get; }
		public Color BaseColor { get; }
		public float BaseAlpha { get; }
		public Color BaseColorOffset { get; }
		public float BaseAlphaOffset { get; }
		public Collider Collider { get; set; }
		public Collider2D Collider2D { get; }
		public Collider SubCollider { get; }
		public int ExistSubCollider { get; }
	
		// Constructors
		public FlObjectBase(GameObject gameObject);
	
		// Methods
		public virtual void _CreateEditorData(FlObjectParameterBase parameter, FlMotion parentMotion);
		public virtual void _ApplyData(FlObjectParameterBase parameter, FlMotion parentMotion);
		public override void _CreateData();
		private void _CheckCollision();
		private void _CheckParentMotion();
		protected override void _ResetPrevValue();
		public override void _ResetTime();
		public override void _FixData();
		public override void _FinalizeData();
		private void _CalculatePlaceOffset();
		private void _SetDepth();
		private void _CheckUI();
		private void _CreateUI();
		public override void _UpdateFirst();
		public override void _UpdateSecond();
		protected virtual void _UpdateVisible();
		protected virtual void _UpdateColor();
		protected virtual void _UpdateTransform();
		protected void _UpdateShear();
		protected virtual void _UpdateBlurValue();
		protected virtual void _UpdateEnableCollision(bool enable);
		protected override void _UpdateSortOrder();
		protected override void _UpdateSortLayer();
		public override void SetSortOffset(int sortOffset);
		public override void SetSortLayer(string sortLayerName);
		public override void SetColliderThrough(bool through, bool affectChildren);
		public override void SetColliderThicknessOffset(float thicknessOffset, bool affectChildren);
		public override void _UpdateColliderThickness(bool affectChildren);
		public override void SetEnableCollider(bool enable, bool affectChildren);
		public override void SetSubCollider(Collider subCollider, bool affectChildren);
		public string GetFlagValue(int flagNo);
		public virtual void SetBaseColor(Color value);
		public virtual void SetBaseAlpha(float alpha);
		public virtual void SetBaseColorOffset(Color value);
		public virtual void SetBaseAlphaOffset(float value);
		public override void SetBlurQuality(int blurQuality, int blurPrecision, bool affectChildren);
		public override void SetBlurValue(Vector2 blurValue, bool affectChildren);
		public override void UpdateTransformVariables();
	}
}

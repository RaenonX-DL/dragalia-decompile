/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameSimpleGaugeUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _rootRt;
		[SerializeField]
		private SpriteRenderer _baseGaugeImage;
		[Header]
		[SerializeField]
		[Tooltip]
		private bool _useGaugeSprite;
		[SerializeField]
		[Tooltip]
		private Sprite[] _gaugeSprite;
		[Header]
		[SerializeField]
		[Tooltip]
		private Color _baseGaugeColor;
		[SerializeField]
		[Tooltip]
		private Color _maxGaugeColor;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _initialValue;
		[SerializeField]
		[Tooltip]
		private float _waitTime;
		[SerializeField]
		[Tooltip]
		private float _diffMoveTime;
		[SerializeField]
		[Tooltip]
		private bool _isNineSlice;
		[SerializeField]
		[Tooltip]
		private bool _isMoveHorizontal;
		private VisibleUIObject _visible;
		private RectTransform _baseGaugeImageRt;
		private Vector2 _baseGaugeOriginalSize;
		private float _targetGaugeRate;
		private float _lastBaseGaugeRate;
		private float _waitRemainTime;
		private bool _lossMoving;
		private bool _gainMoving;
		private bool _isAlphaGauge;
		[CompilerGenerated]
		private Action<float> _OnCompleteAnim_k__BackingField;
	
		// Properties
		public Action<float> OnCompleteAnim { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		private enum BaseGaugeState
		{
			Normal = 0,
			Max = 1
		}
	
		// Constructors
		public InGameSimpleGaugeUI();
	
		// Methods
		public void Initialize();
		public override void FastUpdate();
		private bool UpdateWaitTime(float t);
		private void SetBaseGaugeRate(float rate, bool isForce = false);
		private float GetBaseGaugeRate();
		private void SetBaseGaugeSprite(BaseGaugeState type);
		private void SetBaseGaugeColor(BaseGaugeState type);
		public void SetGaugeRate(float rate, bool immediate, float waitTime = 0f);
		public float GetGaugeRate();
		public bool IsGaugeMax();
		public bool IsGaugeEmpty();
		public void Visible(bool value);
		public void SetWaitTime(float time);
		public void SetBaseGaugeColor(Color color);
		public void SetMaxGaugeColor(Color color);
		public float GetGaugeMoveTime();
		private bool CopyMaterialForAlphaGauge(ref SpriteRenderer image, out bool isAlphaGauge);
	}
}

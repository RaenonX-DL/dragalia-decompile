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
	public class BarrelBombGaugeUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _rootRt;
		[SerializeField]
		private RectTransform _bgRt;
		[SerializeField]
		private RectTransform _blinkRt;
		[SerializeField]
		private SpriteRenderer _bgImage;
		[SerializeField]
		private SpriteRenderer _gaugeImage;
		[SerializeField]
		private SpriteRenderer _iconImage;
		[SerializeField]
		private SpriteRenderer _blinkImage;
		[SerializeField]
		private CircleGauge _gaugeCtrl;
		[Header]
		[SerializeField]
		[Tooltip]
		private float _blinkStartRemainTime;
		[SerializeField]
		[Tooltip]
		private Vector2 _blinkAlpha;
		[SerializeField]
		[Tooltip]
		private float _blinkDurationTime;
		[SerializeField]
		[Tooltip]
		private float _adjust3DPosY;
		[SerializeField]
		[Tooltip]
		private float _adjust2DPosY;
		private VisibleUIObject _rootVisible;
		private VisibleUIObject _blinkVisible;
		private GameObject _owner;
		private Vector3 _settingPosition;
		private Vector3 _settingLocalScale;
		private Color _gaugeColor;
		private bool _show;
		private int _curSortingOrder;
		private int _defSortingOrder;
		private float _blinkTime;
		private BlinkState _blinkState;
		private static int _createCount;
		private int DefaultSortingOrder;
		private static readonly Color[] GAUGE_COLOR;
		private static readonly float[] GAUGE_COLOR_THRESHOLD;
		private static readonly int GAUGE_COLOR_NUM;
	
		// Nested types
		private enum BlinkState
		{
			Idle = 0,
			In = 1,
			Out = 2
		}
	
		// Constructors
		public BarrelBombGaugeUI();
		static BarrelBombGaugeUI();
	
		// Methods
		public static BarrelBombGaugeUI Create(GameObject parent, GameObject owner, int siblingIndex = -1);
		private void Initialize(GameObject owner);
		public void Show();
		public void Hide();
		private void Update();
		private void UpdatePosition();
		public void SetPosition(Vector3 setPosition, Vector3 scale);
		private Vector2 GetScreenPosition(Vector3 position, Vector3 localscale);
		public void SetAdjust2DPosY(float adjust);
		public void SetAdjust3DPosY(float adjust);
		private void UpdateBlink();
		public void SetGaugeTimer(float remainTime, float durationTime);
		private void SetGaugeRate(float rate);
		private Color GetGaugeColor(float rate);
		private void SetBlinkAlpha(float a);
		private void EnableBlink();
		private void DisableBlink();
		private bool IsShow();
		private void InitSortingOrder();
		public void SetSortingOrder(int sortingOrder);
		public void ResetSortingOrder();
		private void SetSortingOrder(int v, bool force = false);
	}
}

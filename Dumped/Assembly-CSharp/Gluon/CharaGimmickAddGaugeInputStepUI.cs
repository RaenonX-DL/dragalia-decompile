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
	public class CharaGimmickAddGaugeInputStepUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _rootRt;
		[SerializeField]
		private RectTransform _gaugeRt;
		[SerializeField]
		private RectTransform _separateRt;
		[SerializeField]
		private SpriteRenderer _gaugeImage;
		[Header]
		[SerializeField]
		private Sprite[] _stepSprite;
		private VisibleUIObject _visibleRoot;
		private VisibleUIObject _visibleGauge;
		private VisibleUIObject _visibleSeparate;
		private float _gaugeWidth;
		private float _separatePosX;
		private bool _initialized;
	
		// Constructors
		public CharaGimmickAddGaugeInputStepUI();
	
		// Methods
		public void Initialize(Transform parent, int index);
		public void SetParam(float rate, bool showSeparate);
		public void ShowGauge();
		public void HideGauge();
		public void Hide();
	}
}

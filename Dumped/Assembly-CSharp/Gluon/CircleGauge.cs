/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CircleGauge : FastUpdateMonoBehaviour
	{
		// Fields
		[Range]
		[SerializeField]
		[Tooltip]
		private float _circleGaugeValue;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _maxCircleGaugeValue;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _startOffsetAngle;
		private SpriteRenderer _spriteRenderer;
	
		// Constructors
		public CircleGauge();
	
		// Methods
		private void Awake();
		public void SetCircleValue(float v);
	}
}

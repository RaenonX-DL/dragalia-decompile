/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class Gauge : FastUpdateMonoBehaviour
	{
		// Fields
		public RectTransform barRect;
		[SerializeField]
		private RectTransform barRectCover;
		[SerializeField]
		[Space]
		public bool useMask;
		[SerializeField]
		public bool immediateChange;
		[Range]
		[SerializeField]
		public float value;
		[SerializeField]
		public float changeDelta;
		[SerializeField]
		public bool canOver100;
		[SerializeField]
		public bool changeHeight;
		[Header]
		[SerializeField]
		[Space]
		public UnityEvent valueChangeCompleted;
		private RectTransform myRect;
		private Vector3 initialPosition;
		private Vector3 initialBarPosition;
		private float maxWidth;
		private float maxHeight;
		public float displayValue;
	
		// Constructors
		public Gauge();
	
		// Methods
		private void Awake();
		public void SetValueImmediate(float arg);
		private void CompleteValueChange();
		public override void FastUpdate();
		private void ShrinkBar();
	}
}

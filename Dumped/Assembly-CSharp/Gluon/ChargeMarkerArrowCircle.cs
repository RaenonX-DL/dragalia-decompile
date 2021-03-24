/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ChargeMarkerArrowCircle : ChargeMarker
	{
		// Fields
		private GameObject goArrow;
		private GameObject[] goPoint;
		private static readonly float[] pointLength;
		private const float maxArrowScale = 1.8f;
	
		// Constructors
		public ChargeMarkerArrowCircle();
		static ChargeMarkerArrowCircle();
	
		// Methods
		protected override void Awake();
		protected override void SetPartsParam();
		public override void UpdatePosition(Vector3 pos);
		private bool UpdatePoint(int visibleNum, float len, Vector3 dir, float arrowScale);
		public override void SetImpactPosition();
		protected override void OnClose();
	}
}

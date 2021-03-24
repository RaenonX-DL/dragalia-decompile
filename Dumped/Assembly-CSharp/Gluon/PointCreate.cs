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
	public class PointCreate : MonoBehaviour
	{
		// Fields
		public BezierCurve bezierCurve;
		public GameObject point;
		public int pointMagnitude;
	
		// Constructors
		public PointCreate();
	
		// Methods
		public void Create();
		private void Create(Vector3 pos);
		public void Remove();
		public float GetAim(Vector2 p1, Vector2 p2);
	}
}

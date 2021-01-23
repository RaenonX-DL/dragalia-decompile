/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RandomXorshift
	{
		// Fields
		private uint x;
		private uint y;
		private uint z;
		private uint w;
	
		// Properties
		public Vector2 insideUnitCircle { get; }
		public Vector3 insideUnitSphere { get; }
		public Vector3 onUnitSphere { get; }
		public float value { get; }
	
		// Constructors
		public RandomXorshift();
		public RandomXorshift(uint seed);
	
		// Methods
		public void SetSeed(uint seed);
		public int Range(int min, int max);
		public float Range(float min, float max);
		private int Next();
		private double NextDouble();
		private uint NextU();
		private uint CalcNext();
	}
}

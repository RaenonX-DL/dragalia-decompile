/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class HitException
	{
		// Fields
		private List<HitVictim> _hitVictims;
		private List<HitVictim> _removedVictims;
		private bool useErrorElimination;
	
		// Properties
		public int HitVictimNum { get; }
	
		// Nested types
		private class HitVictim
		{
			// Fields
			public GameObject victim;
			public float durationSec;
	
			// Constructors
			public HitVictim();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public GameObject obj;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal bool _ContainsGameObject_b__0(HitVictim victims);
		}
	
		// Constructors
		public HitException();
	
		// Methods
		public void SetUseErrorElimination(bool useErrorElimination);
		public void AddHitVictims(GameObject victim, float durationSec);
		public bool IsExcept(GameObject victim);
		public void Clear();
		public void Remove(GameObject victim);
		public void Update();
		public void Update(float deltaTime);
		public bool ContainsGameObject(GameObject obj);
	}
}

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
	public class GrowthManaCircleSideCircleMark : MonoBehaviour
	{
		// Fields
		public State state;
		public GameObject allReleased;
		public GameObject releasable;
		public GameObject limitReleaseRequired;
		public GameObject notReleased;
	
		// Nested types
		public enum State
		{
			AllReleased = 0,
			Releasable = 1,
			LimitReleaseRequired = 2,
			NotReleased = 3
		}
	
		// Constructors
		public GrowthManaCircleSideCircleMark();
	
		// Methods
		private void Awake();
		public void SetState(State state);
	}
}

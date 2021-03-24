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
	public class FootprintsCtrl : MonoBehaviour
	{
		// Fields
		public CharacterBase owner;
	
		// Constructors
		public FootprintsCtrl();
	
		// Methods
		private void OnDisable();
		private void Update();
		private string GetEffectName();
		private bool NeedsPlay();
		public static bool NeedsFootsteps(int decoType);
	}
}

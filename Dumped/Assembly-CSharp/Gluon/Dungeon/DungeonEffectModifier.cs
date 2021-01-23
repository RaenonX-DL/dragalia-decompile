/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	[DisallowMultipleComponent]
	public class DungeonEffectModifier : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private List<DungeonEffectPlayParameter> _modifierList;
	
		// Constructors
		public DungeonEffectModifier();
	
		// Methods
		public DungeonEffectPlayParameter GetPlayParameter(string effectName);
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AIScriptObject : ScriptableObject
	{
		// Fields
		[SerializeField]
		private List<AIScriptContainer> _containers;
	
		// Properties
		public List<AIScriptContainer> containers { get; }
	
		// Constructors
		public AIScriptObject();
	
		// Methods
		public static AIScriptObject CreateAssetInstance();
	}
}

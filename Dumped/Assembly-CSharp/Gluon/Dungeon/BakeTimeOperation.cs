/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class BakeTimeOperation : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Operation _operation;
		[SerializeField]
		[Tooltip]
		private Vector3 _localScale;
	
		// Nested types
		[Flags]
		private enum Operation
		{
			None = 0,
			ScaleX = 1,
			ScaleY = 2,
			ScaleZ = 4
		}
	
		// Constructors
		public BakeTimeOperation();
	}
}

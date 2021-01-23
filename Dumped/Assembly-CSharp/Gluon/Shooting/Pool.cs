/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class Pool
	{
		// Fields
		public BaseObject[] pool;
		public bool useRenderer;
		private int currentIndex;
	
		// Constructors
		public Pool();
	
		// Methods
		public void CreatePool(GameObject template, int count, Transform parent, bool useRenderer = false);
		public void DestroyPool();
		public BaseObject Rent(out int index);
		public void Return(BaseObject bo);
	}
}

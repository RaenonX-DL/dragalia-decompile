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
	public class DestroyStateWatcher : MonoBehaviour
	{
		// Fields
		public Action<bool> enableStateWatcher;
		public Action destroyStateWatcher;
	
		// Constructors
		public DestroyStateWatcher();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		private void OnDestroy();
		public void RemoveAllCallbacksAndDestroySelf();
	}
}

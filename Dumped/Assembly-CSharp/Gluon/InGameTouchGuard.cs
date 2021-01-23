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
	public class InGameTouchGuard : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private RectTransform top;
		[SerializeField]
		private RectTransform bottom;
	
		// Constructors
		public InGameTouchGuard();
	
		// Methods
		public static void Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
	}
}

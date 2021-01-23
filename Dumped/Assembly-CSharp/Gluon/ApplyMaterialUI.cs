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
	public class ApplyMaterialUI : MonoBehaviour
	{
		// Fields
		private SpriteRenderer image;
		private Action func;
	
		// Constructors
		public ApplyMaterialUI();
	
		// Methods
		public void Initialize(Action func);
		public void OnLoaded(Material mtrl);
	}
}

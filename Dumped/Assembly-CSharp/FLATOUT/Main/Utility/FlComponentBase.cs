/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlComponentBase : MonoBehaviour
	{
		// Fields
		protected bool _exist;
		protected FlObjectBase _objectBase;
		protected FlUIBase _uiBase;
	
		// Properties
		public bool Exist { get; }
		public FlObjectBase ObjectBase { get; }
		public FlUIBase UIBase { get; }
	
		// Constructors
		public FlComponentBase();
	
		// Methods
		private void OnDestroy();
		public virtual T Initialize<T>()
			where T : FlUIBase, new();
		protected virtual void _ApplyValue();
		protected virtual void _Initialize_PostProcess();
		protected virtual void _Release();
	}
}

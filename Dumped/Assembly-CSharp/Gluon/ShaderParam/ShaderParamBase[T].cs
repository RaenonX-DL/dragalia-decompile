/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ShaderParam
{
	[Serializable]
	public class ShaderParamBase<T> : ShaderParamCommon<T>
	{
		// Fields
		public T Param;
		[HideInInspector]
		public int PropertyID;
		[HideInInspector]
		public T OldParam;
	
		// Constructors
		public ShaderParamBase();
	
		// Methods
		public override void Start();
		public override void Update();
	}
}

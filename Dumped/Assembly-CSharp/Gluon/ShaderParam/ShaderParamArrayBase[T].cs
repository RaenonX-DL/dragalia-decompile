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
	public class ShaderParamArrayBase<T> : ShaderParamCommon<T>
	{
		// Fields
		public SetGlobalArrayParamFromID setGlobalArrayParamFromID;
		public SetGlobalArrayParamFromName setGlobalArrayParamFromName;
		public T[] Params;
		[HideInInspector]
		public int PropertyID;
		[HideInInspector]
		public T[] OldParams;
	
		// Nested types
		public delegate void SetGlobalArrayParamFromID(int id, T[] param);
	
		public delegate void SetGlobalArrayParamFromName(string name, T[] param);
	
		// Constructors
		public ShaderParamArrayBase();
	
		// Methods
		public override void Start();
		public override void Update();
	}
}

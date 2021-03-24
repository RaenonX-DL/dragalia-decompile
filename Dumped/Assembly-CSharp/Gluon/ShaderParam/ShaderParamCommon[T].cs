/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ShaderParam
{
	[Serializable]
	public class ShaderParamCommon<T> : ShaderParamObject
	{
		// Fields
		public bool StartOnly;
		public string Name;
		public SetGlobalParamFromID setGlobalParamFromID;
		public SetGlobalParamFromName setGlobalParamFromName;
	
		// Nested types
		public delegate void SetGlobalParamFromID(int id, T param);
	
		public delegate void SetGlobalParamFromName(string name, T param);
	
		// Constructors
		public ShaderParamCommon();
	}
}

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
	public class ShaderParamObject
	{
		// Constructors
		public ShaderParamObject();
	
		// Methods
		public virtual void Start();
		public virtual void Update();
		public static void StartArray(ShaderParamObject[] _shaderParams);
		public static void UpdateArray(ShaderParamObject[] _shaderParams);
		public static void AddToArray<T>(ref T[] arrayData, T addData);
	}
}

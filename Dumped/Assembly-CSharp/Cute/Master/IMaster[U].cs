/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Master
{
	public abstract class IMaster<U> : IMasterBase
		where U : IMasterBase
	{
		// Fields
		private static U instance;
	
		// Properties
		public static U Instance { get; private set; }
	
		// Constructors
		protected IMaster();
	
		// Methods
		protected virtual void OnEnable();
		protected virtual void OnDisable();
		public static void Clear();
	}
}

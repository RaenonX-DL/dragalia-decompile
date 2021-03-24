/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public class ObjectTranslatorPool
	{
		// Fields
		private Dictionary<IntPtr, WeakReference> translators;
		private IntPtr lastPtr;
		private ObjectTranslator lastTranslator;
	
		// Properties
		public static ObjectTranslatorPool Instance { get; }
	
		// Constructors
		public ObjectTranslatorPool();
	
		// Methods
		public void Add(IntPtr L, ObjectTranslator translator);
		public ObjectTranslator Find(IntPtr L);
		public void Remove(IntPtr L);
	}
}

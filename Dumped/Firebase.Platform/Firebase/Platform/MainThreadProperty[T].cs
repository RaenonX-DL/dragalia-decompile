/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 39: Firebase.Platform.dll - Assembly: Firebase.Platform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Platform
{
	internal class MainThreadProperty<T>
	{
		// Fields
		private Func<T> getPropertyDelegate;
		private int lastGetPropertyTickCount;
		private T cachedValue;
	
		// Properties
		public T Value { get; }
	
		// Constructors
		public MainThreadProperty(Func<T> getPropertyDelegate);
	
		// Methods
		[CompilerGenerated]
		private T _get_Value_m__0();
	}
}

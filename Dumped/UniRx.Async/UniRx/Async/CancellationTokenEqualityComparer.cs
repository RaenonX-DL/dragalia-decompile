/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public class CancellationTokenEqualityComparer : IEqualityComparer<CancellationToken>
	{
		// Fields
		public static readonly IEqualityComparer<CancellationToken> Default;
	
		// Constructors
		public CancellationTokenEqualityComparer();
		static CancellationTokenEqualityComparer();
	
		// Methods
		public bool Equals(CancellationToken x, CancellationToken y);
		public int GetHashCode(CancellationToken obj);
	}
}

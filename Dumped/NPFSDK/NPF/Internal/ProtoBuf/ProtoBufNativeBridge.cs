﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Internal.ProtoBuf
{
	internal class ProtoBufNativeBridge
	{
		// Fields
		private readonly IDictionary<string, Action<byte[][]>> _callbacks;
		private readonly Func<IExecutor> _executorProvider;
		[CompilerGenerated]
		private static Func<object, byte[]> __f__am_cache3;
	
		// Constructors
		public ProtoBufNativeBridge([JetBrains.Annotations.NotNull] Func<IExecutor> executorProvider);
	
		// Methods
		public void OnReceiveMessage(string message);
		[CompilerGenerated]
		private static byte[] _OnReceiveMessage_m__1C(object base64);
	}
}

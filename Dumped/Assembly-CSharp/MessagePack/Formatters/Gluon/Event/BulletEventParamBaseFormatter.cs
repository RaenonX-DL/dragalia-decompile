/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using MessagePack;
using MessagePack.Formatters;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BulletEventParamBaseFormatter : IMessagePackFormatter<BulletEventParamBase>
	{
		// Fields
		private readonly Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>> typeToKeyAndJumpMap;
		private readonly Dictionary<int, int> keyToJumpMap;
	
		// Constructors
		public BulletEventParamBaseFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, BulletEventParamBase value, IFormatterResolver formatterResolver);
		public BulletEventParamBase Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}

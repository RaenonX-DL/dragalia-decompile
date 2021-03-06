﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;
using MessagePack.Formatters;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters.Gluon
{
	public sealed class RemoveBuffReasonFormatter : IMessagePackFormatter<RemoveBuffReason>
	{
		// Constructors
		public RemoveBuffReasonFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, RemoveBuffReason value, IFormatterResolver formatterResolver);
		public RemoveBuffReason Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}

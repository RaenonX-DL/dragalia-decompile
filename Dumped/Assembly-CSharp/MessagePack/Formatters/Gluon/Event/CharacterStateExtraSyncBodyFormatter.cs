﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using MessagePack;
using MessagePack.Formatters;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class CharacterStateExtraSyncBodyFormatter : IMessagePackFormatter<CharacterStateExtraSyncBody>
	{
		// Fields
		private readonly Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>> typeToKeyAndJumpMap;
		private readonly Dictionary<int, int> keyToJumpMap;
	
		// Constructors
		public CharacterStateExtraSyncBodyFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, CharacterStateExtraSyncBody value, IFormatterResolver formatterResolver);
		public CharacterStateExtraSyncBody Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}

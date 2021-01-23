/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;
using MessagePack.Formatters;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters.Gluon
{
	public sealed class WeaponTypeFormatter : IMessagePackFormatter<WeaponType>
	{
		// Constructors
		public WeaponTypeFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, WeaponType value, IFormatterResolver formatterResolver);
		public WeaponType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}

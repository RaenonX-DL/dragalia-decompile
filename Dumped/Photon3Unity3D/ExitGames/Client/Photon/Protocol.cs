/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExitGames.Client;

// Image 44: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	public class Protocol
	{
		// Fields
		public static readonly IProtocol GpBinaryV16;
		public static readonly IProtocol ProtocolDefault;
		internal static readonly Dictionary<Type, CustomType> TypeDict;
		internal static readonly Dictionary<byte, CustomType> CodeDict;
		private static readonly float[] memFloatBlock;
		private static readonly byte[] memDeserialize;
	
		// Constructors
		static Protocol();
	
		// Methods
		public static void Serialize(short value, byte[] target, ref int targetOffset);
		public static void Serialize(int value, byte[] target, ref int targetOffset);
		public static void Deserialize(out int value, byte[] source, ref int offset);
		public static void Deserialize(out short value, byte[] source, ref int offset);
	}
}

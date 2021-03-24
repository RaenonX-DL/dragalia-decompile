/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.LZ4
{
	public static class LZ4Codec
	{
		// Fields
		private static readonly int[] DECODER_TABLE_32;
		private static readonly int[] DECODER_TABLE_64;
		private static readonly int[] DEBRUIJN_TABLE_32;
		private static readonly int[] DEBRUIJN_TABLE_64;
	
		// Nested types
		internal static class HashTablePool
		{
			// Fields
			[ThreadStatic]
			private static ushort[] ushortPool;
			[ThreadStatic]
			private static int[] intPool;
	
			// Methods
			public static ushort[] GetUShortHashTablePool();
			public static int[] GetIntHashTablePool();
		}
	
		// Constructors
		static LZ4Codec();
	
		// Methods
		public static int MaximumOutputLength(int inputLength);
		internal static void CheckArguments(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);
		public static int Encode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);
		public static int Decode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);
		internal static void Poke2(byte[] buffer, int offset, ushort value);
		internal static ushort Peek2(byte[] buffer, int offset);
		internal static uint Peek4(byte[] buffer, int offset);
		private static uint Xor4(byte[] buffer, int offset1, int offset2);
		private static ulong Xor8(byte[] buffer, int offset1, int offset2);
		private static bool Equal2(byte[] buffer, int offset1, int offset2);
		private static bool Equal4(byte[] buffer, int offset1, int offset2);
		private static void Copy4(byte[] buf, int src, int dst);
		private static void Copy8(byte[] buf, int src, int dst);
		private static void BlockCopy(byte[] src, int src_0, byte[] dst, int dst_0, int len);
		private static int WildCopy(byte[] src, int src_0, byte[] dst, int dst_0, int dst_end);
		private static int SecureCopy(byte[] buffer, int src, int dst, int dst_end);
		public static int Encode32Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);
		public static int Encode64Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);
		public static int Decode32Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);
		public static int Decode64Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);
		private static int LZ4_compressCtx_safe32(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen);
		private static int LZ4_compress64kCtx_safe32(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen);
		private static int LZ4_uncompress_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len);
		private static int LZ4_compressCtx_safe64(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen);
		private static int LZ4_compress64kCtx_safe64(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen);
		private static int LZ4_uncompress_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len);
	}
}

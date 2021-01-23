/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MsgPack
{
	public class MsgPackReader
	{
		// Fields
		private Stream _strm;
		private byte[] _tmp0;
		private byte[] _tmp1;
		private Encoding _encoding;
		private byte[] _buf;
		[CompilerGenerated]
		private TypePrefixes _Type_k__BackingField;
		[CompilerGenerated]
		private bool _ValueBoolean_k__BackingField;
		[CompilerGenerated]
		private uint _Length_k__BackingField;
		[CompilerGenerated]
		private uint _ValueUnsigned_k__BackingField;
		[CompilerGenerated]
		private ulong _ValueUnsigned64_k__BackingField;
		[CompilerGenerated]
		private int _ValueSigned_k__BackingField;
		[CompilerGenerated]
		private long _ValueSigned64_k__BackingField;
		[CompilerGenerated]
		private float _ValueFloat_k__BackingField;
		[CompilerGenerated]
		private double _ValueDouble_k__BackingField;
	
		// Properties
		public TypePrefixes Type { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool ValueBoolean { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public uint Length { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public uint ValueUnsigned { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ulong ValueUnsigned64 { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int ValueSigned { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public long ValueSigned64 { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float ValueFloat { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public double ValueDouble { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public MsgPackReader(Stream strm);
	
		// Methods
		public bool IsSigned();
		public bool IsBoolean();
		public bool IsSigned64();
		public bool IsUnsigned();
		public bool IsUnsigned64();
		public bool IsRaw();
		public bool IsArray();
		public bool IsMap();
		public bool Read();
		public int ReadValueRaw(byte[] buf, int offset, int count);
		public string ReadRawString();
		public string ReadRawString(byte[] buf);
	}
}

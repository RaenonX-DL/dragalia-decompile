/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 42: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	public class StreamBuffer : Stream
	{
		// Fields
		private const int DefaultInitialSize = 0;
		private int pos;
		private int len;
		private byte[] buf;
	
		// Properties
		public override bool CanRead { get; }
		public override bool CanSeek { get; }
		public override bool CanWrite { get; }
		public override long Length { get; }
		public override long Position { get; set; }
	
		// Constructors
		public StreamBuffer(int size = 0);
		public StreamBuffer(byte[] buf);
	
		// Methods
		public byte[] ToArray();
		public override void Flush();
		public override long Seek(long offset, SeekOrigin origin);
		public override void SetLength(long value);
		public override int Read(byte[] buffer, int offset, int count);
		public override void Write(byte[] buffer, int offset, int count);
		public override int ReadByte();
		public override void WriteByte(byte value);
		private bool CheckSize(int size);
	}
}

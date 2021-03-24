/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class MissionReceiveAlbumRewardRequestFormatter : IMessagePackFormatter<MissionReceiveAlbumRewardRequest>
	{
		// Fields
		private readonly AutomataDictionary ____keyMapping;
		private readonly byte[][] ____stringByteKeys;
	
		// Constructors
		public MissionReceiveAlbumRewardRequestFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, MissionReceiveAlbumRewardRequest value, IFormatterResolver formatterResolver);
		public MissionReceiveAlbumRewardRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}

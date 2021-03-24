/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ProtoBuf;

// Image 39: protobuf-net.dll - Assembly: protobuf-net, Version=2.0.0.668, Culture=neutral, PublicKeyToken=257b51d87d2e4d67

namespace ProtoBuf.Meta
{
	public abstract class TypeModel
	{
		// Fields
		private static readonly Type ilist;
	
		// Constructors
		protected TypeModel();
		static TypeModel();
	
		// Methods
		protected internal virtual bool SerializeDateTimeKind();
		protected internal static Type ResolveProxies(Type type);
		protected abstract int GetKeyImpl(Type type);
		protected internal abstract void Serialize(int key, object value, ProtoWriter dest);
		protected internal abstract object Deserialize(int key, object value, ProtoReader source);
		protected internal static void ThrowUnexpectedSubtype(Type expected, Type actual);
	}
}

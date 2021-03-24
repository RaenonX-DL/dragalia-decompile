/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 39: protobuf-net.dll - Assembly: protobuf-net, Version=2.0.0.668, Culture=neutral, PublicKeyToken=257b51d87d2e4d67

namespace ProtoBuf
{
	[AttributeUsage]
	public class ProtoMemberAttribute : Attribute, IComparable, IComparable<ProtoBuf.ProtoMemberAttribute>
	{
		// Fields
		private string name;
		private DataFormat dataFormat;
		private int tag;
		private MemberSerializationOptions options;
	
		// Properties
		public string Name { set; }
		public DataFormat DataFormat { set; }
		public bool IsRequired { set; }
	
		// Constructors
		public ProtoMemberAttribute(int tag);
		internal ProtoMemberAttribute(int tag, bool forced);
	
		// Methods
		public int CompareTo(object other);
		public int CompareTo(ProtoMemberAttribute other);
	}
}

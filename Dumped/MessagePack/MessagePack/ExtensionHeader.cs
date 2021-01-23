/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 48: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack
{
	public struct ExtensionHeader
	{
		// Fields
		[CompilerGenerated]
		private sbyte _TypeCode_k__BackingField;
		[CompilerGenerated]
		private uint _Length_k__BackingField;
	
		// Properties
		public sbyte TypeCode { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private uint Length { [CompilerGenerated] set; }
	
		// Constructors
		public ExtensionHeader(sbyte typeCode, uint length);
	}
}

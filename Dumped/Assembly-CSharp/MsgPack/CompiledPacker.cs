/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MsgPack
{
	public class CompiledPacker
	{
		// Fields
		private static PackerBase _publicFieldPacker;
		private static PackerBase _allFieldPacker;
		private PackerBase _packer;
	
		// Nested types
		public abstract class PackerBase
		{
			// Fields
			private Dictionary<Type, Delegate> _packers;
			private Dictionary<Type, Delegate> _unpackers;
			protected Dictionary<Type, MethodInfo> _packMethods;
			protected Dictionary<Type, MethodInfo> _unpackMethods;
	
			// Constructors
			protected PackerBase();
	
			// Methods
			public Action<MsgPackWriter, T> CreatePacker<T>();
			public Func<MsgPackReader, T> CreateUnpacker<T>();
			protected abstract Action<MsgPackWriter, T> CreatePacker_Internal<T>();
			protected abstract Func<MsgPackReader, T> CreateUnpacker_Internal<T>();
		}
	
		public sealed class DynamicMethodPacker : PackerBase
		{
			// Fields
			private static MethodInfo LookupMemberMappingMethod;
			private static Dictionary<Type, IDictionary<string, int>> UnpackMemberMappings;
			private static int _dynamicMethodIdx;
	
			// Constructors
			static DynamicMethodPacker();
			public DynamicMethodPacker();
	
			// Methods
			protected override Action<MsgPackWriter, T> CreatePacker_Internal<T>();
			protected override Func<MsgPackReader, T> CreateUnpacker_Internal<T>();
			private DynamicMethod CreatePacker(Type t, DynamicMethod dm);
			private DynamicMethod CreateUnpacker(Type t, DynamicMethod dm);
			private static DynamicMethod CreatePackDynamicMethod(Type t);
			private static DynamicMethod CreateUnpackDynamicMethod(Type t);
			private static MemberInfo[] LookupMembers(Type t);
			private MethodInfo LookupPackMethod(Type t);
			private MethodInfo LookupUnpackMethod(Type t);
			private static string FormatMemberName(MemberInfo m);
			private static DynamicMethod CreateDynamicMethod(Type returnType, Type[] parameterTypes);
			internal static IDictionary<string, int> LookupMemberMapping(Type t);
		}
	
		public sealed class MethodBuilderPacker : PackerBase
		{
			// Fields
			public const string AssemblyName = "MessagePackInternalAssembly";
			private static AssemblyName DynamicAsmName;
			private static AssemblyBuilder DynamicAsmBuilder;
			private static ModuleBuilder DynamicModuleBuilder;
			private static MethodInfo LookupMemberMappingMethod;
			private static Dictionary<Type, IDictionary<string, int>> UnpackMemberMappings;
	
			// Constructors
			static MethodBuilderPacker();
			public MethodBuilderPacker();
	
			// Methods
			protected override Action<MsgPackWriter, T> CreatePacker_Internal<T>();
			protected override Func<MsgPackReader, T> CreateUnpacker_Internal<T>();
			private void CreatePacker(Type t, MethodBuilder mb);
			private void CreateUnpacker(Type t, MethodBuilder mb);
			private MethodInfo ToCallableMethodInfo(Type t, TypeBuilder tb, bool isPacker);
			private MethodInfo LookupPackMethod(Type t);
			private MethodInfo LookupUnpackMethod(Type t);
			private static string FormatMemberName(MemberInfo m);
			private static MemberInfo[] LookupMembers(Type t);
			private static void CreatePackMethodBuilder(Type t, out TypeBuilder tb, out MethodBuilder mb);
			private static void CreateUnpackMethodBuilder(Type t, out TypeBuilder tb, out MethodBuilder mb);
			internal static IDictionary<string, int> LookupMemberMapping(Type t);
		}
	
		internal static class DefaultPackMethods
		{
			// Methods
			public static void Register(Dictionary<Type, MethodInfo> packMethods, Dictionary<Type, MethodInfo> unpackMethods);
			private static void RegisterPackMethods(Dictionary<Type, MethodInfo> packMethods);
			internal static void Pack(MsgPackWriter writer, string x);
			private static void RegisterUnpackMethods(Dictionary<Type, MethodInfo> unpackMethods);
			internal static int Unpack_Signed(MsgPackReader reader);
			internal static long Unpack_Signed64(MsgPackReader reader);
			internal static uint Unpack_Unsigned(MsgPackReader reader);
			internal static ulong Unpack_Unsigned64(MsgPackReader reader);
			internal static bool Unpack_Boolean(MsgPackReader reader);
			internal static float Unpack_Float(MsgPackReader reader);
			internal static double Unpack_Double(MsgPackReader reader);
			internal static string Unpack_String(MsgPackReader reader);
			internal static void UnpackFailed();
		}
	
		// Constructors
		static CompiledPacker();
		public CompiledPacker();
		public CompiledPacker(bool packPrivateField);
	
		// Methods
		public void Prepare<T>();
		public byte[] Pack<T>(T o);
		public void Pack<T>(Stream strm, T o);
		public T Unpack<T>(byte[] buf);
		public T Unpack<T>(byte[] buf, int offset, int size);
		public T Unpack<T>(Stream strm);
		public byte[] Pack(object o);
		public void Pack(Stream strm, object o);
		public object Unpack(Type t, byte[] buf);
		public object Unpack(Type t, byte[] buf, int offset, int size);
		public object Unpack(Type t, Stream strm);
	}
}

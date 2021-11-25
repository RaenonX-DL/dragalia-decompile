using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

namespace MsgPack
{
	public class CompiledPacker
	{
		public abstract class PackerBase
		{
			private Dictionary<Type, Delegate> _packers;

			private Dictionary<Type, Delegate> _unpackers;

			protected Dictionary<Type, MethodInfo> _packMethods;

			protected Dictionary<Type, MethodInfo> _unpackMethods;

			public Action<MsgPackWriter, T> CreatePacker<T>()
			{
				return null;
			}

			public Func<MsgPackReader, T> CreateUnpacker<T>()
			{
				return null;
			}

			protected abstract Action<MsgPackWriter, T> CreatePacker_Internal<T>();

			protected abstract Func<MsgPackReader, T> CreateUnpacker_Internal<T>();
		}

		public sealed class DynamicMethodPacker : PackerBase
		{
			private static MethodInfo LookupMemberMappingMethod;

			private static Dictionary<Type, IDictionary<string, int>> UnpackMemberMappings;

			private static int _dynamicMethodIdx;

			static DynamicMethodPacker()
			{
			}

			protected override Action<MsgPackWriter, T> CreatePacker_Internal<T>()
			{
				return null;
			}

			protected override Func<MsgPackReader, T> CreateUnpacker_Internal<T>()
			{
				return null;
			}

			private DynamicMethod CreatePacker(Type t, DynamicMethod dm)
			{
				return null;
			}

			private DynamicMethod CreateUnpacker(Type t, DynamicMethod dm)
			{
				return null;
			}

			private static DynamicMethod CreatePackDynamicMethod(Type t)
			{
				return null;
			}

			private static DynamicMethod CreateUnpackDynamicMethod(Type t)
			{
				return null;
			}

			private static MemberInfo[] LookupMembers(Type t)
			{
				return null;
			}

			private MethodInfo LookupPackMethod(Type t)
			{
				return null;
			}

			private MethodInfo LookupUnpackMethod(Type t)
			{
				return null;
			}

			private static string FormatMemberName(MemberInfo m)
			{
				return null;
			}

			private static DynamicMethod CreateDynamicMethod(Type returnType, Type[] parameterTypes)
			{
				return null;
			}

			internal static IDictionary<string, int> LookupMemberMapping(Type t)
			{
				return null;
			}
		}

		public sealed class MethodBuilderPacker : PackerBase
		{
			public const string AssemblyName = "MessagePackInternalAssembly";

			private static AssemblyName DynamicAsmName;

			private static AssemblyBuilder DynamicAsmBuilder;

			private static ModuleBuilder DynamicModuleBuilder;

			private static MethodInfo LookupMemberMappingMethod;

			private static Dictionary<Type, IDictionary<string, int>> UnpackMemberMappings;

			static MethodBuilderPacker()
			{
			}

			protected override Action<MsgPackWriter, T> CreatePacker_Internal<T>()
			{
				return null;
			}

			protected override Func<MsgPackReader, T> CreateUnpacker_Internal<T>()
			{
				return null;
			}

			private void CreatePacker(Type t, MethodBuilder mb)
			{
			}

			private void CreateUnpacker(Type t, MethodBuilder mb)
			{
			}

			private MethodInfo ToCallableMethodInfo(Type t, TypeBuilder tb, bool isPacker)
			{
				return null;
			}

			private MethodInfo LookupPackMethod(Type t)
			{
				return null;
			}

			private MethodInfo LookupUnpackMethod(Type t)
			{
				return null;
			}

			private static string FormatMemberName(MemberInfo m)
			{
				return null;
			}

			private static MemberInfo[] LookupMembers(Type t)
			{
				return null;
			}

			private static void CreatePackMethodBuilder(Type t, out TypeBuilder tb, out MethodBuilder mb)
			{
			}

			private static void CreateUnpackMethodBuilder(Type t, out TypeBuilder tb, out MethodBuilder mb)
			{
			}

			internal static IDictionary<string, int> LookupMemberMapping(Type t)
			{
				return null;
			}
		}

		internal static class DefaultPackMethods
		{
			public static void Register(Dictionary<Type, MethodInfo> packMethods, Dictionary<Type, MethodInfo> unpackMethods)
			{
			}

			private static void RegisterPackMethods(Dictionary<Type, MethodInfo> packMethods)
			{
			}

			internal static void Pack(MsgPackWriter writer, string x)
			{
			}

			private static void RegisterUnpackMethods(Dictionary<Type, MethodInfo> unpackMethods)
			{
			}

			internal static int Unpack_Signed(MsgPackReader reader)
			{
				return default(int);
			}

			internal static long Unpack_Signed64(MsgPackReader reader)
			{
				return default(long);
			}

			internal static uint Unpack_Unsigned(MsgPackReader reader)
			{
				return default(uint);
			}

			internal static ulong Unpack_Unsigned64(MsgPackReader reader)
			{
				return default(ulong);
			}

			internal static bool Unpack_Boolean(MsgPackReader reader)
			{
				return default(bool);
			}

			internal static float Unpack_Float(MsgPackReader reader)
			{
				return default(float);
			}

			internal static double Unpack_Double(MsgPackReader reader)
			{
				return default(double);
			}

			internal static string Unpack_String(MsgPackReader reader)
			{
				return null;
			}

			internal static void UnpackFailed()
			{
			}
		}

		private static PackerBase _publicFieldPacker;

		private static PackerBase _allFieldPacker;

		private PackerBase _packer;

		static CompiledPacker()
		{
		}

		public CompiledPacker()
		{
		}

		public CompiledPacker(bool packPrivateField)
		{
		}

		public void Prepare<T>()
		{
		}

		public byte[] Pack<T>(T o)
		{
			return null;
		}

		public void Pack<T>(Stream strm, T o)
		{
		}

		public T Unpack<T>(byte[] buf)
		{
			return (T)null;
		}

		public T Unpack<T>(byte[] buf, int offset, int size)
		{
			return (T)null;
		}

		public T Unpack<T>(Stream strm)
		{
			return (T)null;
		}

		public byte[] Pack(object o)
		{
			return null;
		}

		public void Pack(Stream strm, object o)
		{
		}

		public object Unpack(Type t, byte[] buf)
		{
			return null;
		}

		public object Unpack(Type t, byte[] buf, int offset, int size)
		{
			return null;
		}

		public object Unpack(Type t, Stream strm)
		{
			return null;
		}
	}
}

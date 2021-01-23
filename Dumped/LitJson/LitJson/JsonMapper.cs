/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 47: LitJson.dll - Assembly: LitJson, Version=0.9.0.0, Culture=neutral, PublicKeyToken=null

namespace LitJson
{
	public class JsonMapper
	{
		// Fields
		private static int max_nesting_depth;
		private static IFormatProvider datetime_format;
		private static IDictionary<Type, ExporterFunc> base_exporters_table;
		private static IDictionary<Type, ExporterFunc> custom_exporters_table;
		private static IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;
		private static IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;
		private static IDictionary<Type, ArrayMetadata> array_metadata;
		private static readonly object array_metadata_lock;
		private static IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;
		private static readonly object conv_ops_lock;
		private static IDictionary<Type, ObjectMetadata> object_metadata;
		private static readonly object object_metadata_lock;
		private static IDictionary<Type, IList<PropertyMetadata>> type_properties;
		private static readonly object type_properties_lock;
		private static JsonWriter static_writer;
		private static readonly object static_writer_lock;
		[CompilerGenerated]
		private static WrapperFactory __f__am_cache0;
		[CompilerGenerated]
		private static ExporterFunc __f__am_cache1;
		[CompilerGenerated]
		private static ExporterFunc __f__am_cache2;
		[CompilerGenerated]
		private static ExporterFunc __f__am_cache3;
		[CompilerGenerated]
		private static ExporterFunc __f__am_cache4;
		[CompilerGenerated]
		private static ExporterFunc __f__am_cache5;
		[CompilerGenerated]
		private static ExporterFunc __f__am_cache6;
		[CompilerGenerated]
		private static ExporterFunc __f__am_cache7;
		[CompilerGenerated]
		private static ExporterFunc __f__am_cache8;
		[CompilerGenerated]
		private static ExporterFunc __f__am_cache9;
		[CompilerGenerated]
		private static ImporterFunc __f__am_cacheA;
		[CompilerGenerated]
		private static ImporterFunc __f__am_cacheB;
		[CompilerGenerated]
		private static ImporterFunc __f__am_cacheC;
		[CompilerGenerated]
		private static ImporterFunc __f__am_cacheD;
		[CompilerGenerated]
		private static ImporterFunc __f__am_cacheE;
		[CompilerGenerated]
		private static ImporterFunc __f__am_cacheF;
		[CompilerGenerated]
		private static ImporterFunc __f__am_cache10;
		[CompilerGenerated]
		private static ImporterFunc __f__am_cache11;
		[CompilerGenerated]
		private static ImporterFunc __f__am_cache12;
		[CompilerGenerated]
		private static ImporterFunc __f__am_cache13;
		[CompilerGenerated]
		private static ImporterFunc __f__am_cache14;
		[CompilerGenerated]
		private static ImporterFunc __f__am_cache15;
		[CompilerGenerated]
		private static WrapperFactory __f__am_cache18;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _RegisterExporter_c__AnonStorey0<T>
		{
			// Fields
			internal ExporterFunc<T> exporter;
	
			// Constructors
			public _RegisterExporter_c__AnonStorey0();
	
			// Methods
			internal void __m__0(object obj, JsonWriter writer);
		}
	
		[CompilerGenerated]
		private sealed class _RegisterImporter_c__AnonStorey1<TJson, TValue>
		{
			// Fields
			internal ImporterFunc<TJson, TValue> importer;
	
			// Constructors
			public _RegisterImporter_c__AnonStorey1();
	
			// Methods
			internal object __m__0(object input);
		}
	
		// Constructors
		static JsonMapper();
	
		// Methods
		private static void AddArrayMetadata(Type type);
		private static void AddObjectMetadata(Type type);
		private static void AddTypeProperties(Type type);
		private static MethodInfo GetConvOp(Type t1, Type t2);
		private static object ReadValue(Type inst_type, JsonReader reader);
		private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader);
		private static void ReadSkip(JsonReader reader);
		private static void RegisterBaseExporters();
		private static void RegisterBaseImporters();
		private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer);
		private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth);
		public static string ToJson(object obj);
		public static JsonData ToObject(string json);
		public static T ToObject<T>(string json);
		public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader);
		public static IJsonWrapper ToWrapper(WrapperFactory factory, string json);
		public static void RegisterExporter<T>(ExporterFunc<T> exporter);
		public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer);
		[CompilerGenerated]
		private static IJsonWrapper _ReadSkip_m__0();
		[CompilerGenerated]
		private static void _RegisterBaseExporters_m__1(object obj, JsonWriter writer);
		[CompilerGenerated]
		private static void _RegisterBaseExporters_m__2(object obj, JsonWriter writer);
		[CompilerGenerated]
		private static void _RegisterBaseExporters_m__3(object obj, JsonWriter writer);
		[CompilerGenerated]
		private static void _RegisterBaseExporters_m__4(object obj, JsonWriter writer);
		[CompilerGenerated]
		private static void _RegisterBaseExporters_m__5(object obj, JsonWriter writer);
		[CompilerGenerated]
		private static void _RegisterBaseExporters_m__6(object obj, JsonWriter writer);
		[CompilerGenerated]
		private static void _RegisterBaseExporters_m__7(object obj, JsonWriter writer);
		[CompilerGenerated]
		private static void _RegisterBaseExporters_m__8(object obj, JsonWriter writer);
		[CompilerGenerated]
		private static void _RegisterBaseExporters_m__9(object obj, JsonWriter writer);
		[CompilerGenerated]
		private static object _RegisterBaseImporters_m__A(object input);
		[CompilerGenerated]
		private static object _RegisterBaseImporters_m__B(object input);
		[CompilerGenerated]
		private static object _RegisterBaseImporters_m__C(object input);
		[CompilerGenerated]
		private static object _RegisterBaseImporters_m__D(object input);
		[CompilerGenerated]
		private static object _RegisterBaseImporters_m__E(object input);
		[CompilerGenerated]
		private static object _RegisterBaseImporters_m__F(object input);
		[CompilerGenerated]
		private static object _RegisterBaseImporters_m__10(object input);
		[CompilerGenerated]
		private static object _RegisterBaseImporters_m__11(object input);
		[CompilerGenerated]
		private static object _RegisterBaseImporters_m__12(object input);
		[CompilerGenerated]
		private static object _RegisterBaseImporters_m__13(object input);
		[CompilerGenerated]
		private static object _RegisterBaseImporters_m__14(object input);
		[CompilerGenerated]
		private static object _RegisterBaseImporters_m__15(object input);
		[CompilerGenerated]
		private static IJsonWrapper _ToObject_m__18();
	}
}

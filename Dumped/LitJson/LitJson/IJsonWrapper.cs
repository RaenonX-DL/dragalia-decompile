/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 50: LitJson.dll - Assembly: LitJson, Version=0.9.0.0, Culture=neutral, PublicKeyToken=null

namespace LitJson
{
	public interface IJsonWrapper : IList, IOrderedDictionary
	{
		// Properties
		bool IsArray { get; }
		bool IsBoolean { get; }
		bool IsDouble { get; }
		bool IsInt { get; }
		bool IsLong { get; }
		bool IsObject { get; }
		bool IsString { get; }
	
		// Methods
		bool GetBoolean();
		double GetDouble();
		int GetInt();
		long GetLong();
		string GetString();
		void SetBoolean(bool val);
		void SetDouble(double val);
		void SetInt(int val);
		void SetJsonType(JsonType type);
		void SetLong(long val);
		void SetString(string val);
		string ToJson();
		void ToJson(JsonWriter writer);
	}
}

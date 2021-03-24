/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Internal.Mapper
{
	public abstract class BaseMapper<T>
	{
		// Constructors
		protected BaseMapper();
	
		// Methods
		public abstract T FromDictionary(IDictionary<string, object> jsonObject);
		[NotNull]
		public T[] FromListToArray(IList<object> jsonArray);
		[NotNull]
		public IList<T> FromList(IList<object> jsonArray);
		internal bool HasField(IDictionary<string, object> json, string field);
		internal bool HasFields(IDictionary<string, object> json, params string[] fields);
		[NotNull]
		internal IDictionary<string, string> ToStringDictionary(IDictionary dict);
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public interface ICuttTimelineKeyDataList
	{
		// Properties
		CuttTimelineKey this[int index] { get => default; set {} }
		int Count { get; }
		CuttTimelineKeyDataListAttr attribute { get; set; }
		int depthCounter { get; }
	
		// Methods
		void Insert(int index, CuttTimelineKey item);
		IEnumerator<CuttTimelineKey> GetEnumerator();
		void Add(CuttTimelineKey item);
		void Clear();
		bool Remove(CuttTimelineKey item);
		void RemoveAt(int index);
		IEnumerable<CuttTimelineKey> ToEnumerable();
		CuttTimelineKey At(int index);
		CuttTimelineKey[] ToArray();
		List<CuttTimelineKey> ToList();
		bool HasAttribute(CuttTimelineKeyDataListAttr attr);
		FindKeyResult FindKeyCached(int frame, bool ignoreCache);
		FindKeyResult FindCurrentKey(int frame);
		FindKeyResult FindCurrentKeyNeighbor(int frame, int baseIndex);
	}
}

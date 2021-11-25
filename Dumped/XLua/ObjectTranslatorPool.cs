using System;
using System.Collections.Generic;

namespace XLua
{
	public class ObjectTranslatorPool
	{
		private Dictionary<IntPtr, WeakReference> translators;

		private IntPtr lastPtr;

		private ObjectTranslator lastTranslator;

		public static ObjectTranslatorPool Instance => null;

		public void Add(IntPtr L, ObjectTranslator translator)
		{
		}

		public ObjectTranslator Find(IntPtr L)
		{
			return null;
		}

		public void Remove(IntPtr L)
		{
		}
	}
}

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyDataListTemplate<T> : ICuttTimelineKeyDataList where T : CuttTimelineKey
	{
		[SerializeField]
		private CuttTimelineKeyDataListAttr _attribute;

		public List<T> thisList;

		private int _lastFindIndex;

		public CuttTimelineKeyDataListAttr attribute
		{
			get
			{
				return default(CuttTimelineKeyDataListAttr);
			}
			set
			{
			}
		}

		public CuttTimelineKey this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => default(int);

		public int depthCounter => default(int);

		public bool HasAttribute(CuttTimelineKeyDataListAttr attr)
		{
			return default(bool);
		}

		public void Insert(int index, CuttTimelineKey item)
		{
		}

		public void Add(CuttTimelineKey item)
		{
		}

		public void Clear()
		{
		}

		public bool Remove(CuttTimelineKey item)
		{
			return default(bool);
		}

		public void RemoveAt(int index)
		{
		}

		public IEnumerator<CuttTimelineKey> GetEnumerator()
		{
			return null;
		}

		public IEnumerable<CuttTimelineKey> ToEnumerable()
		{
			return null;
		}

		public CuttTimelineKey At(int index)
		{
			return null;
		}

		public CuttTimelineKey[] ToArray()
		{
			return null;
		}

		public List<CuttTimelineKey> ToList()
		{
			return null;
		}

		public FindKeyResult FindKeyCached(int frame, bool forceRefind)
		{
			return default(FindKeyResult);
		}

		public FindKeyResult FindCurrentKey(int frame)
		{
			return default(FindKeyResult);
		}

		private void BinSearch(out FindKeyResult ret, int frame, int indexS, int indexE, int listSize)
		{
		}

		public void FindKeyLinear(out CuttTimelineKey curKey, out CuttTimelineKey nextKey, int curFrame)
		{
		}

		public FindKeyResult FindCurrentKeyNeighbor(int frame, int baseIndex)
		{
			return default(FindKeyResult);
		}
	}
}

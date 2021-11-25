using System.Collections.Generic;

namespace Cutt
{
	public interface ICuttTimelineKeyDataList
	{
		CuttTimelineKey this[int index] { get; set; }

		int Count { get; }

		CuttTimelineKeyDataListAttr attribute { get; set; }

		int depthCounter { get; }

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

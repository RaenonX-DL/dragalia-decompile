using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CommonReportCategory : IMaster<CommonReportCategory>
	{
		[SerializeField]
		private CommonReportCategoryDictionary dict;

		public CommonReportCategoryDictionary Dict => null;

		public SerializableDictionary<int, CommonReportCategoryElement>.ValueCollection List => null;
	}
}

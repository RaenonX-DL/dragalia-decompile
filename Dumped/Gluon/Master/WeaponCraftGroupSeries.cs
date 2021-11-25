using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponCraftGroupSeries : IMaster<WeaponCraftGroupSeries>
	{
		[SerializeField]
		private WeaponCraftGroupSeriesDictionary dict;

		public WeaponCraftGroupSeriesDictionary Dict => null;

		public SerializableDictionary<int, WeaponCraftGroupSeriesElement>.ValueCollection List => null;
	}
}

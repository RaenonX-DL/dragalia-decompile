using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class WeaponBodyGroupSeries : IMaster<WeaponBodyGroupSeries>
	{
		[SerializeField]
		private WeaponBodyGroupSeriesDictionary dict;

		public WeaponBodyGroupSeriesDictionary Dict => null;

		public SerializableDictionary<int, WeaponBodyGroupSeriesElement>.ValueCollection List => null;
	}
}

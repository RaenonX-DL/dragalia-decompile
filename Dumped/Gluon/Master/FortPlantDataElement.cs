using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class FortPlantDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Description;

		[SerializeField]
		private FortPlantType _Type;

		[SerializeField]
		private int _DetailId;

		[SerializeField]
		private int _PlantSize;

		[SerializeField]
		private string _WorkPrefabName;

		[SerializeField]
		private FortMenuGroupType _MenuGroup;

		[SerializeField]
		private int _Movable;

		[SerializeField]
		private int _Storable;

		[SerializeField]
		private int _Valid;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _MaxsetsUserLevel1;

		[SerializeField]
		private int _MaxsetsSet1;

		[SerializeField]
		private int _MaxsetsUserLevel2;

		[SerializeField]
		private int _MaxsetsSet2;

		[SerializeField]
		private int _MaxsetsUserLevel3;

		[SerializeField]
		private int _MaxsetsSet3;

		[SerializeField]
		private int _MaxsetsUserLevel4;

		[SerializeField]
		private int _MaxsetsSet4;

		[SerializeField]
		private int _MaxsetsUserLevel5;

		[SerializeField]
		private int _MaxsetsSet5;

		[SerializeField]
		private int _MaxPlantQuantity;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private string _EventDescription;

		[SerializeField]
		private string _EventMenuDescription;

		public int Id => default(int);

		public string Name => null;

		public string Description => null;

		public FortPlantType Type => default(FortPlantType);

		public int DetailId => default(int);

		public int PlantSize => default(int);

		public string WorkPrefabName => null;

		public FortMenuGroupType MenuGroup => default(FortMenuGroupType);

		public int Movable => default(int);

		public int Storable => default(int);

		public int Valid => default(int);

		public int SortId => default(int);

		public int MaxsetsUserLevel1 => default(int);

		public int MaxsetsSet1 => default(int);

		public int MaxsetsUserLevel2 => default(int);

		public int MaxsetsSet2 => default(int);

		public int MaxsetsUserLevel3 => default(int);

		public int MaxsetsSet3 => default(int);

		public int MaxsetsUserLevel4 => default(int);

		public int MaxsetsSet4 => default(int);

		public int MaxsetsUserLevel5 => default(int);

		public int MaxsetsSet5 => default(int);

		public int MaxPlantQuantity => default(int);

		public int EventId => default(int);

		public string EventDescription => null;

		public string EventMenuDescription => null;
	}
}

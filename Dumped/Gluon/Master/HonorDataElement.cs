using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class HonorDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _HonorName;

		[SerializeField]
		private string _Description;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private MissionTransportType _HonorTransportType;

		[SerializeField]
		private int _TransportValue;

		[SerializeField]
		private string _StartDate;

		[SerializeField]
		private string _EndDate;

		public int Id => default(int);

		public string HonorName => null;

		public string Description => null;

		public int SortId => default(int);

		public MissionTransportType HonorTransportType => default(MissionTransportType);

		public int TransportValue => default(int);

		public string StartDate => null;

		public string EndDate => null;
	}
}

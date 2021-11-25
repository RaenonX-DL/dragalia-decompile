using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DragonReliabilityLevelElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _DragonUnitType;

		[SerializeField]
		private int _Level;

		[SerializeField]
		private int _NecessaryReliability;

		[SerializeField]
		private int _TotalReliability;

		public int Id => default(int);

		public int DragonUnitType => default(int);

		public int Level => default(int);

		public int NecessaryReliability => default(int);

		public int TotalReliability => default(int);
	}
}

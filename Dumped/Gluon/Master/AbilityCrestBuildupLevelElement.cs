using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AbilityCrestBuildupLevelElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _RarityGroup;

		[SerializeField]
		private int _Level;

		[SerializeField]
		private int _BuildupMaterialId1;

		[SerializeField]
		private int _BuildupMaterialQuantity1;

		[SerializeField]
		private int _BuildupMaterialId2;

		[SerializeField]
		private int _BuildupMaterialQuantity2;

		[SerializeField]
		private int _BuildupMaterialId3;

		[SerializeField]
		private int _BuildupMaterialQuantity3;

		[SerializeField]
		private int _UniqueBuildupMaterialCount;

		public int Id => default(int);

		public int RarityGroup => default(int);

		public int Level => default(int);

		public int BuildupMaterialId1 => default(int);

		public int BuildupMaterialQuantity1 => default(int);

		public int BuildupMaterialId2 => default(int);

		public int BuildupMaterialQuantity2 => default(int);

		public int BuildupMaterialId3 => default(int);

		public int BuildupMaterialQuantity3 => default(int);

		public int UniqueBuildupMaterialCount => default(int);
	}
}

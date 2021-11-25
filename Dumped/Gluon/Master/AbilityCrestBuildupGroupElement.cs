using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AbilityCrestBuildupGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _AbilityCrestBuildupGroupId;

		[SerializeField]
		private BuildupPieceType _BuildupPieceType;

		[SerializeField]
		private int _Step;

		[SerializeField]
		private int _UnlockConditionLevel;

		[SerializeField]
		private int _UnlockConditionLimitBreakCount;

		[SerializeField]
		private int _BuildupDewPoint;

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

		public int AbilityCrestBuildupGroupId => default(int);

		public BuildupPieceType BuildupPieceType => default(BuildupPieceType);

		public int Step => default(int);

		public int UnlockConditionLevel => default(int);

		public int UnlockConditionLimitBreakCount => default(int);

		public int BuildupDewPoint => default(int);

		public int BuildupMaterialId1 => default(int);

		public int BuildupMaterialQuantity1 => default(int);

		public int BuildupMaterialId2 => default(int);

		public int BuildupMaterialQuantity2 => default(int);

		public int BuildupMaterialId3 => default(int);

		public int BuildupMaterialQuantity3 => default(int);

		public int UniqueBuildupMaterialCount => default(int);
	}
}

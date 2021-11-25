using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class OperateBgData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsOperateBg.OperateType _operateType;

		[SerializeField]
		[HideInInspector]
		private DungeonBgModelProduction.ChangeBgTextureProductionKind _texProdKind;

		[SerializeField]
		[HideInInspector]
		private int _switchTransformId;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public Gluon.ActionPartsOperateBg.OperateType operateType => default(Gluon.ActionPartsOperateBg.OperateType);

		public DungeonBgModelProduction.ChangeBgTextureProductionKind texProdKind => default(DungeonBgModelProduction.ChangeBgTextureProductionKind);

		public int switchTransformId => default(int);

		public bool guarantee => default(bool);
	}
}

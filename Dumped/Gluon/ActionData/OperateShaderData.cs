using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class OperateShaderData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsOperateShader.OperateType _operateType;

		[SerializeField]
		[HideInInspector]
		private int _opticalCamouflageId;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public Gluon.ActionPartsOperateShader.OperateType operateType => default(Gluon.ActionPartsOperateShader.OperateType);

		public int opticalCamouflageId => default(int);

		public bool guarantee => default(bool);
	}
}

using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickMovePanelObjElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private float _Velocity;

		public string Id => null;

		public float Velocity => default(float);
	}
}

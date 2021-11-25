using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickTimedSwitchElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private float _Time;

		public string Id => null;

		public float Time => default(float);
	}
}

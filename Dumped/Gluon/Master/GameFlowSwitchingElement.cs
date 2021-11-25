using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GameFlowSwitchingElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Flag;

		[SerializeField]
		private int _ParamInt01;

		[SerializeField]
		private int _ParamInt02;

		[SerializeField]
		private float _ParamFloat01;

		[SerializeField]
		private float _ParamFloat02;

		public int Id => default(int);

		public int Flag => default(int);

		public int ParamInt01 => default(int);

		public int ParamInt02 => default(int);

		public float ParamFloat01 => default(float);

		public float ParamFloat02 => default(float);
	}
}

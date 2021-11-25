using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ActionTargetElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Label;

		[SerializeField]
		private ActionTargetGroup _Group;

		public int Id => default(int);

		public string Label => null;

		public ActionTargetGroup Group => default(ActionTargetGroup);
	}
}

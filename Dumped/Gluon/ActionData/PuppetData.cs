using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class PuppetData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsPuppet.Mode _mode;

		[SerializeField]
		[HideInInspector]
		private int _bootActionId;

		[SerializeField]
		[HideInInspector]
		private int _abortActionId;

		[SerializeField]
		[HideInInspector]
		private float _runningTime;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public Gluon.ActionPartsPuppet.Mode mode => default(Gluon.ActionPartsPuppet.Mode);

		public int bootActionId => default(int);

		public int abortActionId => default(int);

		public float runningTime => default(float);

		public bool guarantee => default(bool);
	}
}

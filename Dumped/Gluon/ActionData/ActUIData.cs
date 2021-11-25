using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ActUIData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private string _fileName;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public string fileName => null;

		public bool guarantee => default(bool);
	}
}

using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ShishimaiReCloseBoxData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private string _childMotion;

		public string childMotion => null;
	}
}

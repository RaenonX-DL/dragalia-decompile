using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SetupAlloutAssaultData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private AlloutAssaultUniqueCtrl.EventType _eventType;

		public static readonly int PARAMETER_SET_NUM;

		[SerializeField]
		[HideInInspector]
		private int[] _paramId;

		[SerializeField]
		[HideInInspector]
		private string[] _assaultHitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private string[] _voiceLabel;

		public AlloutAssaultUniqueCtrl.EventType eventType => default(AlloutAssaultUniqueCtrl.EventType);

		public int[] paramId => null;

		public string[] assaultHitAttrLabel => null;

		public string[] voiceLabel => null;
	}
}

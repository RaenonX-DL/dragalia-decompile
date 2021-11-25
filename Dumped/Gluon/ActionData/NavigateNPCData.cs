using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class NavigateNPCData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _talkId;

		[SerializeField]
		[HideInInspector]
		private bool _isLeftIcon;

		[SerializeField]
		[HideInInspector]
		private bool _isOneTime;

		public const int TALKER_NUM = 10;

		[SerializeField]
		[HideInInspector]
		private int[] _talkers;

		public int talk => default(int);

		public bool isLeftIcon => default(bool);

		public bool isOneTime => default(bool);

		public int[] talkers => null;
	}
}

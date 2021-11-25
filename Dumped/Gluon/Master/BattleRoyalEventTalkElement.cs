using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BattleRoyalEventTalkElement : IMasterElement
	{
		[SerializeField]
		private int _CharaId;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private int _Category0;

		[SerializeField]
		private int _Category1;

		[SerializeField]
		private string _TopCharaImage;

		[SerializeField]
		private float _TopCharaImageOffsetX;

		[SerializeField]
		private float _TopCharaImageOffsetY;

		[SerializeField]
		private string _TargetName;

		[SerializeField]
		private string _Text;

		[SerializeField]
		private string _VoiceData;

		public int CharaId => default(int);

		public int EventId => default(int);

		public int Category0 => default(int);

		public int Category1 => default(int);

		public string TopCharaImage => null;

		public float TopCharaImageOffsetX => default(float);

		public float TopCharaImageOffsetY => default(float);

		public string TargetName => null;

		public string Text => null;

		public string VoiceData => null;
	}
}

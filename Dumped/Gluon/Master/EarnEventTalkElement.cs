using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EarnEventTalkElement : IMasterElement
	{
		[SerializeField]
		private int _CharaId;

		[SerializeField]
		private int _Category0;

		[SerializeField]
		private int _Category1;

		[SerializeField]
		private int _TargetValue1;

		[SerializeField]
		private int _TargetValue2;

		[SerializeField]
		private int _EventTopId;

		[SerializeField]
		private string _TopCharaImage;

		[SerializeField]
		private float _TopCharaImageOffsetX;

		[SerializeField]
		private float _TopCharaImageOffsetY;

		[SerializeField]
		private float _TopCharaImageMoveOffset;

		[SerializeField]
		private float _TopCharaImageMoveOffsetY;

		[SerializeField]
		private string _TargetName;

		[SerializeField]
		private string _Text;

		[SerializeField]
		private string _VoiceData;

		public int CharaId => default(int);

		public int Category0 => default(int);

		public int Category1 => default(int);

		public int TargetValue1 => default(int);

		public int TargetValue2 => default(int);

		public int EventTopId => default(int);

		public string TopCharaImage => null;

		public float TopCharaImageOffsetX => default(float);

		public float TopCharaImageOffsetY => default(float);

		public float TopCharaImageMoveOffset => default(float);

		public float TopCharaImageMoveOffsetY => default(float);

		public string TargetName => null;

		public string Text => null;

		public string VoiceData => null;
	}
}

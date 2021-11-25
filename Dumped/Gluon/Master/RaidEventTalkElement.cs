using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class RaidEventTalkElement : IMasterElement
	{
		[SerializeField]
		private int _CharaId;

		[SerializeField]
		private int _Category0;

		[SerializeField]
		private int _Category1;

		[SerializeField]
		private string _TargetName;

		[SerializeField]
		private int _Value;

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
		private string _Text;

		[SerializeField]
		private string _VoiceData;

		public int CharaId => default(int);

		public int Category0 => default(int);

		public int Category1 => default(int);

		public string TargetName => null;

		public int Value => default(int);

		public string TopCharaImage => null;

		public float TopCharaImageOffsetX => default(float);

		public float TopCharaImageOffsetY => default(float);

		public float TopCharaImageMoveOffset => default(float);

		public float TopCharaImageMoveOffsetY => default(float);

		public string Text => null;

		public string VoiceData => null;
	}
}

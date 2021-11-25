using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MenuTalkElement : IMasterElement
	{
		[SerializeField]
		private int _CharaId;

		[SerializeField]
		private int _MenuTalkGroupId;

		[SerializeField]
		private int _Category0;

		[SerializeField]
		private int _Category1;

		[SerializeField]
		private int _ImageTypeNum;

		[SerializeField]
		private string _Text;

		[SerializeField]
		private string _VoiceData;

		public int CharaId => default(int);

		public int MenuTalkGroupId => default(int);

		public int Category0 => default(int);

		public int Category1 => default(int);

		public int ImageTypeNum => default(int);

		public string Text => null;

		public string VoiceData => null;
	}
}

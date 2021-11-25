using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class SeasonVoiceElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _VoiceId;

		[SerializeField]
		private string _VoiceIconImage;

		[SerializeField]
		private string _StartDate;

		[SerializeField]
		private string _EndDate;

		public int Id => default(int);

		public int VoiceId => default(int);

		public string VoiceIconImage => null;

		public string StartDate => null;

		public string EndDate => null;
	}
}

using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MypageLimitedAreaNPCElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _BaseId;

		[SerializeField]
		private int _VariationId;

		[SerializeField]
		private string _Motion;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Text;

		[SerializeField]
		private string _VoiceData;

		public int Id => default(int);

		public int BaseId => default(int);

		public int VariationId => default(int);

		public string Motion => null;

		public string Name => null;

		public string Text => null;

		public string VoiceData => null;
	}
}

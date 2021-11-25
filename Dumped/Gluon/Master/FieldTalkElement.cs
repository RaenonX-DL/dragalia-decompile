using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class FieldTalkElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _BaseId;

		[SerializeField]
		private int _VariationId;

		[SerializeField]
		private int _TypeId;

		[SerializeField]
		private string _Text;

		[SerializeField]
		private int _WindowType;

		[SerializeField]
		private string _VoiceId;

		public int Id => default(int);

		public int BaseId => default(int);

		public int VariationId => default(int);

		public int TypeId => default(int);

		public string Text => null;

		public int WindowType => default(int);

		public string VoiceId => null;
	}
}

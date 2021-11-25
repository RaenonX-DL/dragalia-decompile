using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DrillTalkElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Category0;

		[SerializeField]
		private int _Category1;

		[SerializeField]
		private int _TargetValue;

		[SerializeField]
		private string _UnitFaceSkin;

		[SerializeField]
		private string _UnitMotion;

		[SerializeField]
		private string _WaitMotion;

		[SerializeField]
		private string _Text;

		[SerializeField]
		private string _VoiceData;

		public int Id => default(int);

		public int Category0 => default(int);

		public int Category1 => default(int);

		public int TargetValue => default(int);

		public string UnitFaceSkin => null;

		public string UnitMotion => null;

		public string WaitMotion => null;

		public string Text => null;

		public string VoiceData => null;
	}
}

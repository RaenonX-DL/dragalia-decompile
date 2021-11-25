using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AuraEffectElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _EffectName;

		[SerializeField]
		private int _GroupId;

		[SerializeField]
		private int _TriggerType;

		[SerializeField]
		private string _BindPos;

		public int Id => default(int);

		public string EffectName => null;

		public int GroupId => default(int);

		public int TriggerType => default(int);

		public string BindPos => null;
	}
}

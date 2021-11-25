using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyActionElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _ActionGroupName;

		[SerializeField]
		private float _Range;

		[SerializeField]
		private float _AiGiveUpTime;

		[SerializeField]
		private float _ActionTempoN;

		[SerializeField]
		private float _ActionTempoH;

		[SerializeField]
		private float _ActionTempoVH;

		[SerializeField]
		private float _ActionTempoEX;

		[SerializeField]
		private float _ActionTempoHell;

		[SerializeField]
		private float _ActionTempo6;

		[SerializeField]
		private float _ActionTempo7;

		[SerializeField]
		private float _ActionTempo8;

		[SerializeField]
		private float _ActionTempo9;

		[SerializeField]
		private float _ActionTempo10;

		[SerializeField]
		private int _IsOrderAction;

		[SerializeField]
		private int _IsExtraAction;

		[SerializeField]
		private string _NameNoElement;

		[SerializeField]
		private string _NameFire;

		[SerializeField]
		private string _NameWater;

		[SerializeField]
		private string _NameWind;

		[SerializeField]
		private string _NameLight;

		[SerializeField]
		private string _NameDark;

		[SerializeField]
		private int _IsForcedAnnihilationAction;

		public int Id => default(int);

		public string ActionGroupName => null;

		public float Range => default(float);

		public float AiGiveUpTime => default(float);

		public float ActionTempoN => default(float);

		public float ActionTempoH => default(float);

		public float ActionTempoVH => default(float);

		public float ActionTempoEX => default(float);

		public float ActionTempoHell => default(float);

		public float ActionTempo6 => default(float);

		public float ActionTempo7 => default(float);

		public float ActionTempo8 => default(float);

		public float ActionTempo9 => default(float);

		public float ActionTempo10 => default(float);

		public int IsOrderAction => default(int);

		public int IsExtraAction => default(int);

		public string NameNoElement => null;

		public string NameFire => null;

		public string NameWater => null;

		public string NameWind => null;

		public string NameLight => null;

		public string NameDark => null;

		public int IsForcedAnnihilationAction => default(int);
	}
}

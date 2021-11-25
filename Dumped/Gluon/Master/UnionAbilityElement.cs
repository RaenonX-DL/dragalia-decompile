using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class UnionAbilityElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _IconEffect;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _CrestGroup1Count1;

		[SerializeField]
		private int _AbilityId1;

		[SerializeField]
		private int _PartyPower1;

		[SerializeField]
		private int _CrestGroup1Count2;

		[SerializeField]
		private int _AbilityId2;

		[SerializeField]
		private int _PartyPower2;

		[SerializeField]
		private int _CrestGroup1Count3;

		[SerializeField]
		private int _AbilityId3;

		[SerializeField]
		private int _PartyPower3;

		[SerializeField]
		private int _CrestGroup1Count4;

		[SerializeField]
		private int _AbilityId4;

		[SerializeField]
		private int _PartyPower4;

		[SerializeField]
		private int _CrestGroup1Count5;

		[SerializeField]
		private int _AbilityId5;

		[SerializeField]
		private int _PartyPower5;

		public int Id => default(int);

		public string Name => null;

		public string IconEffect => null;

		public int SortId => default(int);

		public int CrestGroup1Count1 => default(int);

		public int AbilityId1 => default(int);

		public int PartyPower1 => default(int);

		public int CrestGroup1Count2 => default(int);

		public int AbilityId2 => default(int);

		public int PartyPower2 => default(int);

		public int CrestGroup1Count3 => default(int);

		public int AbilityId3 => default(int);

		public int PartyPower3 => default(int);

		public int CrestGroup1Count4 => default(int);

		public int AbilityId4 => default(int);

		public int PartyPower4 => default(int);

		public int CrestGroup1Count5 => default(int);

		public int AbilityId5 => default(int);

		public int PartyPower5 => default(int);
	}
}

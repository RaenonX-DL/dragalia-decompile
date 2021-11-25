using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CharaUniqueComboElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _ActionId;

		[SerializeField]
		private int _ExActionId;

		[SerializeField]
		private int _MaxComboNum;

		[SerializeField]
		private int _ShiftConditionType;

		[SerializeField]
		private int _ConditionArgs1;

		[SerializeField]
		private string _BuffHitAttribute;

		public int Id => default(int);

		public int ActionId => default(int);

		public int ExActionId => default(int);

		public int MaxComboNum => default(int);

		public int ShiftConditionType => default(int);

		public int ConditionArgs1 => default(int);

		public string BuffHitAttribute => null;
	}
}

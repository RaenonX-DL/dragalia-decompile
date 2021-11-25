using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class LoginLotteryElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _StartDate;

		[SerializeField]
		private string _EndDate;

		public int Id => default(int);

		public string StartDate => null;

		public string EndDate => null;
	}
}

using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestFailedTypeElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Subject;

		public int Id => default(int);

		public string Subject => null;
	}
}

using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestMissionCompleteTypeElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Subject;

		[SerializeField]
		private string _ZeroValueSubject;

		public int Id => default(int);

		public string Subject => null;

		public string ZeroValueSubject => null;
	}
}

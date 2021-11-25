using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DefenseEventTalkElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private DefenseEventWindowType _WindowType;

		[SerializeField]
		private DefenseEventIconType _IconType;

		[SerializeField]
		private string _IconName;

		[SerializeField]
		private int _QuestGroupId;

		[SerializeField]
		private int _QuestId;

		[SerializeField]
		private int _NextAreaMessage;

		[SerializeField]
		private string _Text;

		public int Id => default(int);

		public DefenseEventWindowType WindowType => default(DefenseEventWindowType);

		public DefenseEventIconType IconType => default(DefenseEventIconType);

		public string IconName => null;

		public int QuestGroupId => default(int);

		public int QuestId => default(int);

		public int NextAreaMessage => default(int);

		public string Text => null;
	}
}

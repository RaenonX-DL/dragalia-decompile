using System;

namespace Gluon
{
	[Serializable]
	public class StoryCommand
	{
		public int row;

		public string command;

		public string[] args;

		public bool end;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Gluon
{
	[Serializable]
	public class StoryFunction
	{
		public string name;

		public string[] args;

		public string[] defaultValues;

		public List<StoryCommand> commandList;

		public StoryVariables variables;

		public string filename
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}

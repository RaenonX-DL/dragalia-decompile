using System.Collections.Generic;

namespace Gluon
{
	public class StoryScriptParser
	{
		private StoryFunction currentFunction;

		private StoryScript storyScript;

		private int numIf;

		private int numEndIf;

		public StoryScript Parse(string text, string filename)
		{
			return null;
		}

		private string ParseComment(string line, ref bool isComment)
		{
			return null;
		}

		private void ParseLine(string line, int row)
		{
		}

		private void ParseCommand(string line, int row, ref int current, List<StoryCommand> commandList)
		{
		}
	}
}

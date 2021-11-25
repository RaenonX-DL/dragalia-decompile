using System.Collections.Generic;

namespace Gluon
{
	public class AIScriptLoader
	{
		private const string scriptPath = "AIScript/";

		private const string scriptDirectoryPath = "Assets/_GluonResources/AIScriptWork/";

		private const string outputDirectoryPath = "Assets/_GluonResources/Resources/AIScript/";

		private const string outputSyntaxLogName = "Gluon/Action/Enabled Output SyntaxLog";

		private Dictionary<string, AIScriptParser> _dict;

		public AIScriptParser Load(string scriptFile)
		{
			return null;
		}

		private void Clear()
		{
		}
	}
}

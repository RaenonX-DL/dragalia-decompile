using System.Collections.Generic;

namespace Gluon
{
	public class TalkParser
	{
		public enum Reword
		{
			BreakPlayer
		}

		private static TalkParser _instance;

		private string[] RewordStr;

		private Dictionary<string, string> _rewordDict;

		public static TalkParser Instance => null;

		public static void Release()
		{
		}

		public void SetReword(Reword parser, string str)
		{
		}

		public string Parser(string str)
		{
			return null;
		}
	}
}

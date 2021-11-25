using System.Runtime.CompilerServices;

namespace XLua.TemplateEngine
{
	public class Chunk
	{
		public TokenType Type
		{
			[CompilerGenerated]
			get
			{
				return default(TokenType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Text
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Chunk(TokenType type, string text)
		{
		}
	}
}

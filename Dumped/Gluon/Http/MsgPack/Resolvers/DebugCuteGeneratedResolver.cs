using MessagePack;
using MessagePack.Formatters;

namespace Gluon.Http.MsgPack.Resolvers
{
	public class DebugCuteGeneratedResolver : IFormatterResolver
	{
		private static class FormatterCache<T>
		{
			public static readonly IMessagePackFormatter<T> formatter;

			static FormatterCache()
			{
			}
		}

		public static readonly IFormatterResolver Instance;

		private DebugCuteGeneratedResolver()
		{
		}

		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}
	}
}

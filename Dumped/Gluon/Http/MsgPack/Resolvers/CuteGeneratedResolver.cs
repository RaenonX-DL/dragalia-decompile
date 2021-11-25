using MessagePack;
using MessagePack.Formatters;

namespace Gluon.Http.MsgPack.Resolvers
{
	public class CuteGeneratedResolver : IFormatterResolver
	{
		private static class FormatterCache<T>
		{
			public static readonly IMessagePackFormatter<T> formatter;

			static FormatterCache()
			{
			}
		}

		public static readonly IFormatterResolver Instance;

		private CuteGeneratedResolver()
		{
		}

		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}
	}
}

using System.Runtime.InteropServices;

namespace XLua.TemplateEngine
{
	[StructLayout(3, Size = 4)]
	public enum TokenType
	{
		Code,
		Eval,
		Text
	}
}

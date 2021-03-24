/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public class Logger : ILogger
	{
		// Fields
		private static readonly string TIME_FMT;
		private static readonly string TRACE_FMT;
		private string name;
		private string fullname;
		private InternalTraceLevel maxLevel;
		private TextWriter writer;
	
		// Constructors
		public Logger(string name, InternalTraceLevel level, TextWriter writer);
		static Logger();
	
		// Methods
		public void Error(string message);
		public void Debug(string message);
		public void Debug(string message, params object[] args);
		private void Log(InternalTraceLevel level, string message);
		private void Log(InternalTraceLevel level, string format, params object[] args);
		private void WriteLog(InternalTraceLevel level, string message);
	}
}

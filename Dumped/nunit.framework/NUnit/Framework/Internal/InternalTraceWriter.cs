/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public class InternalTraceWriter : TextWriter
	{
		// Fields
		private TextWriter writer;
		private object myLock;
	
		// Properties
		public override Encoding Encoding { get; }
	
		// Methods
		public override void Write(char value);
		public override void Write(string value);
		public override void WriteLine(string value);
		protected override void Dispose(bool disposing);
		public override void Flush();
	}
}

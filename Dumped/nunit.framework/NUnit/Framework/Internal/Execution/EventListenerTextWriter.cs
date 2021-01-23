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

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal.Execution
{
	public class EventListenerTextWriter : TextWriter
	{
		// Fields
		private TextWriter _defaultWriter;
		private string _streamName;
	
		// Properties
		public override Encoding Encoding { get; }
	
		// Constructors
		public EventListenerTextWriter(string streamName, TextWriter defaultWriter);
	
		// Methods
		public override void Write(char aChar);
		public override void Write(string aString);
		public override void WriteLine(string aString);
		private bool TrySendToListener(string text);
	}
}

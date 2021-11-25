using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames
{
	[StructLayout(3, Size = 8)]
	internal delegate void ReportProgress(string id, double progress, Action<bool> callback);
}

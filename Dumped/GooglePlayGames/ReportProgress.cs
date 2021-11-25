using System;

namespace GooglePlayGames
{
	internal delegate void ReportProgress(string id, double progress, Action<bool> callback);
}

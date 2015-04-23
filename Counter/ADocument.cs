﻿using System.IO;

namespace Counter
{
	internal abstract class ADocument : IDocument
	{
		public abstract DocumentType Type { get; }
		public abstract uint Count { get; protected set; }

		protected ADocument()
		{
			Count = 0;
		}
	}
}
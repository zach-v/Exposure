﻿using Exposure.Contracts;

namespace Exposure.Utilities.Procedural {
	public class HardSeedProvider : BaseSeedProvider {
		private static int seedLength = 1500000;

		public HardSeedProvider() : base(seedLength) {
		}
	}
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ItzWarty.Threading {
   public interface ICancellationToken : IEquatable<ICancellationToken>, IDisposable {
      ICancellationTokenSource Source { get; }

      bool IsCancellationRequested { get; }
      bool CanBeCanceled { get; }
      void ThrowIfCancellationRequested();

      bool WaitForCancellation(int millisecondsTimeout);
      bool WaitForCancellation(TimeSpan timeout);

      CancellationToken __InnerToken { get; }
   }
}

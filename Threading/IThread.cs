﻿using System;

namespace ItzWarty.Threading {
   public interface IThread : IDisposable {
      void Start();

      void Join();
      bool Join(TimeSpan timeout);
   }
}
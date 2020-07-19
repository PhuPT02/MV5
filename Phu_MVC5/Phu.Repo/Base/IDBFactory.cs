using System;

namespace Phu.Data.Base
{
    public interface IDbFactory : IDisposable
    {
        PhuDBContext Init();
    }
}
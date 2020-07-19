using System;

namespace Phu.Data.Base
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
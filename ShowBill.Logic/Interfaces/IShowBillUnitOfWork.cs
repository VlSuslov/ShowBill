using System;

namespace ShowBill.Logic
{
    public interface IShowBillUnitOfWork: IDisposable
    {
        IEventMetaRepository MetaRepository { get; }   
        void Save();
    }
}

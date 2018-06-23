using System;

namespace ShowBill.Data
{
    public interface IShowBillUnitOfWork: IDisposable
    {
        IEventMetaRepository MetaRepository { get; }   
        void Save();
    }
}

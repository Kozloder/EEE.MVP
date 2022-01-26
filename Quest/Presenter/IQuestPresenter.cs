using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public interface IQuestPresenter : IDisposable
    {
        IQuestModel Model { get; }
        IQuestView View { get; }
    }
}
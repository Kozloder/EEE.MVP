using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public interface IQuestModel
    {
        event Action OnCompleted;
        event Action OnFailed;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public class WalletModel : IReadOnlyWalletModel
    {
        public float Value { get; }

        public WalletModel(float money)
        {
            this.Value = money;
        }
    }
}
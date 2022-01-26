using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEE
{
    public class RewardWalletModel : IWalletModel, IRewardWallet
    {
        private IWalletModel destinationWallet;

        public float Value { get; set; }

        public RewardWalletModel(IWalletModel destinationWallet)
        {
            this.destinationWallet = destinationWallet;
        }

        public void Reward()
        {
            destinationWallet.Value += Value;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MahApps.Metro.IconPacks
{
    [MarkupExtensionReturnType(typeof(PackIconCryptoCoins))]
    public class PackIconCryptoCoinsExtension : PackIconExtension<PackIconCryptoCoins, PackIconCryptoCoinsKind>
    {
        public PackIconCryptoCoinsExtension()
        {
        }

        public PackIconCryptoCoinsExtension(PackIconCryptoCoinsKind kind) : base(kind)
        {
        }
    }
}

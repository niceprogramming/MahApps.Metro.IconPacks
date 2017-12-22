using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MahApps.Metro.IconPacks
{
   
        /// <summary>
        /// Icons from Crypto Coins - <see><cref>https://github.com/allienworks/cryptocoins</cref></see>.
        /// </summary>
        public class PackIconCryptoCoins : PackIcon<PackIconCryptoCoinsKind>
        {
#if !NETFX_CORE
            static PackIconCryptoCoins()
            {
                DefaultStyleKeyProperty.OverrideMetadata(typeof(IconPacks.PackIconCryptoCoins), new FrameworkPropertyMetadata(typeof(IconPacks.PackIconCryptoCoins)));
            }
#endif

            public PackIconCryptoCoins() : base(PackIconCrytoCoinsDataFactory.Create)
            {
#if NETFX_CORE
            this.DefaultStyleKey = typeof(PackIconEntypo);
#endif
            }
        }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_TISO_DOMAIN.Business
{
    static class WishlistRepository
    {
        private static List<Wishlist> _wishlists = new List<Wishlist>();
        public static List<Wishlist> Wishlists
        {
            get { return _wishlists; }
            set { _wishlists = value; }
        }
        public static void addWishlists(Wishlist item)
        {
            _wishlists.Add(item);
        }
    }
}

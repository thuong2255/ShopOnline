using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infratructure
{
    /*Dùng để khởi tạo các đối tượng Entity*/
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}

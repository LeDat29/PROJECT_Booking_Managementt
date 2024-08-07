using OnlineOrder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrder.Repos
{
    public interface IOnlineOrderRepo
    {
        IEnumerable<Category> GetAllCategory();
        public void AddCategory(Category category);

    }
}
